using Cbe.DomainException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml;
using System.Data;

namespace RiskAppetite.Services.ExcelUpload
{
    public class ExcelUpload : IExcelUpload
    {
        private readonly string _connectionString;

        public ExcelUpload(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("cbe_Risk_Apetite");
        }
        

        private int GetNextIdFromDatabase()
        {
            int nextId = NextIdCounter.GetNextId();
            return nextId;
        }

        public static class NextIdCounter
        {
            private static int counter = 1;

            public static int GetNextId()
            {
                return counter++;
            }
        }
        public async Task<string> UploadExcelFile(IFormFile file, string destinationTable, int uploaderUserId)
        {
            if (file == null || file.Length <= 0)
                throw new DataNotFoundException("Invalid file");

            if (!Path.GetExtension(file.FileName).Equals(".xlsx", System.StringComparison.OrdinalIgnoreCase))
                throw new DataNotFoundException("Invalid file format. Only Excel files are supported.");

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets[0]; // Assuming data is on the first sheet
                    var rowCount = worksheet.Dimension.Rows;

                    int headerColumnCount = 0;

                    var columnCount = worksheet.Dimension.Columns;

                    for(int col = 1; col <= columnCount; col++)
                    {
                        var cellValue = worksheet.Cells[1,col].Value?.ToString();
                        if(!string.IsNullOrEmpty(cellValue))
                            headerColumnCount++;
                    }

                    DataTable dataTable = new DataTable();

                    // Add columns dynamically based on the column names in the Excel file
                    for (int col = 1; col <= columnCount; col++)
                    {
                        string columnName = worksheet.Cells[1,col].Value?.ToString()??String.Empty;
                        DataColumn column = new DataColumn(columnName,typeof(string));
                        column.MaxLength = 150;
                        dataTable.Columns.Add(column);
                        
                    }

                    dataTable.Columns.Add("uploaderUserId", typeof(int)); // Add the uploaderuserid column to the DataTable
                    dataTable.Columns.Add("approverUserId", typeof(int)); // Add the uploaderuserid column to the DataTable
                    dataTable.Columns.Add("approvalstatus", typeof(int)); // Add the uploaderuserid column to the DataTable
                    dataTable.Columns.Add("uploadedDate", typeof(DateTime)); // Add the updateddate column to the DataTable
                    dataTable.Columns.Add("approvedDate", typeof(DateTime)); // Add the approveruserid column to the DataTable
                    dataTable.Columns.Add("Id", typeof(int));
                    // Set constant values for uploaderuserid, updateddate, and approveruserid
                    DateTime updatedDate = DateTime.UtcNow;
                    int approverUserId = 1; // Replace with the actual value
                    int approvalstatus = 0; // Replace with the actual value

                    // Add rows to DataTable with values from the Excel file and constant values for other columns
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int col = 1; col <= columnCount; col++)
                        {
                            string columnName = dataTable.Columns[col - 1].ColumnName;
                            object cellvalue=worksheet.Cells[row, col].Value;
                            dataRow[columnName] = (cellvalue!=null)? cellvalue.ToString() : null;
                           
                        }

                        dataRow["uploaderUserId"] = uploaderUserId;
                        dataRow["approverUserId"] = approverUserId;
                        dataRow["approvalstatus"] = approvalstatus;
                        dataRow["uploadedDate"] = updatedDate;
                        dataRow["approvedDate"] = updatedDate;
                        dataRow["Id"] = GetNextIdFromDatabase();
                        dataTable.Rows.Add(dataRow);
                    }

                    // Save DataTable to database, excluding the 'id' column
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                        {
                            bulkCopy.DestinationTableName = destinationTable;

                            for (int col = 1; col <= headerColumnCount; col++)
                            {
                                string columnName = dataTable.Columns[col - 1].ColumnName;
                                if (!columnName.Equals("Id", StringComparison.OrdinalIgnoreCase))
                                    bulkCopy.ColumnMappings.Add(columnName, columnName);
                            }
                            bulkCopy.ColumnMappings.Add("uploaderUserId", "uploaderUserId");
                            bulkCopy.ColumnMappings.Add("approverUserId", "approverUserId");
                            bulkCopy.ColumnMappings.Add("approvalstatus", "approvalstatus");
                            bulkCopy.ColumnMappings.Add("uploadedDate", "uploadedDate");
                            bulkCopy.ColumnMappings.Add("approvedDate", "approvedDate");                  
                            bulkCopy.WriteToServer(dataTable);
                            connection.Close();
                        }
                    }
                }
            }

            return "Successfully uploaded";
        }
    }
}
