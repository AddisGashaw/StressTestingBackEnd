using Cbe.DomainException;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
        //public async Task<string> UploadExcelFile(IFormFile file, string destinationTable,int uploaderUserId)
        //{
        //        if (file == null || file.Length <= 0)
        //            throw new DataNotFoundException("Invalid file");

        //        if (!Path.GetExtension(file.FileName).Equals(".xlsx", System.StringComparison.OrdinalIgnoreCase))
        //            throw new DataNotFoundException("Invalid file format. Only Excel files are supported.");
        //        using (var stream = new MemoryStream())
        //        {
        //            await file.CopyToAsync(stream);
        //            using (var package = new ExcelPackage(stream))
        //            {
        //                var worksheet = package.Workbook.Worksheets[0]; // Assuming data is on the first sheet
        //                var rowCount = worksheet.Dimension.Rows;
        //                var columnCount = worksheet.Dimension.Columns;

        //                DataTable dataTable = new DataTable();
        //            dataTable.Columns.Add("UploaderUserId", typeof(int)); // Add the UploaderUserId column
        //            dataTable.Columns.Add("UploadedDate", typeof(DateTime)); // Add the UploadedDate column
        //            dataTable.Columns.Add("Id", typeof(int)); // Add the Id column to the DataTable

        //                // Create columns in DataTable
        //                for (int col = 1; col <= columnCount; col++)
        //                {
        //                    dataTable.Columns.Add(worksheet.Cells[1, col].Value.ToString());
        //                }

        //                // Add rows to DataTable with generated IDs
        //                for (int row = 2; row <= rowCount; row++)
        //                {
        //                    DataRow dataRow = dataTable.NewRow();
        //                dataRow["UploaderUserId"] = uploaderUserId; // Set the UploaderUserId
        //                dataRow["UploadedDate"] = DateTime.UtcNow; // Set the UploadedDate to the current UTC date and time
        //                dataRow["Id"] = GetNextIdFromDatabase(); // Generate a unique ID for each record
        //                    for (int col = 1; col <= columnCount; col++)
        //                    {
        //                        dataRow[col] = worksheet.Cells[row, col].Value.ToString();
        //                    }
        //                    dataTable.Rows.Add(dataRow);
        //                }

        //                // Save DataTable to database
        //                using (SqlConnection connection = new SqlConnection(_connectionString))
        //                {
        //                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
        //                    {
        //                        bulkCopy.DestinationTableName = destinationTable;
        //                        connection.Open();
        //                        bulkCopy.WriteToServer(dataTable);
        //                        connection.Close();
        //                    }
        //                }
        //            }
        //        }

        //        return "Successfully uploaded";

        //}

        //private int GetNextIdFromDatabase()
        //{
        //    // Implement your logic to generate a unique ID from the database
        //    // You can use various techniques, such as querying the database for the last inserted ID and incrementing it
        //    // or using a sequence generator

        //    // Sample implementation using a counter
        //    // Store the counter value in a persistent storage like a database table or file
        //    // Retrieve the counter value, increment it, and update the storage with the new value
        //    // Return the updated counter value as the ID

        //    // Replace this with your actual logic to generate the next ID
        //    // For simplicity, this example uses a static counter
        //    int nextId = NextIdCounter.GetNextId();
        //    return nextId;
        //}

        //public static class NextIdCounter
        //{
        //    private static int counter = 1;

        //    public static int GetNextId()
        //    {
        //        return counter++;
        //    }
        //}
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
                    var columnCount = worksheet.Dimension.Columns;

                    DataTable dataTable = new DataTable();

                    // Add columns dynamically based on the column names in the Excel file
                    for (int col = 1; col <= columnCount; col++)
                    {
                        string columnName = worksheet.Cells[1, col].Value?.ToString() ?? $"Column{col}";
                        dataTable.Columns.Add(columnName, typeof(string));
                    }

                    dataTable.Columns.Add("uploaderUserId", typeof(int)); // Add the uploaderuserid column to the DataTable
                    dataTable.Columns.Add("approverUserId", typeof(int)); // Add the uploaderuserid column to the DataTable
                    dataTable.Columns.Add("approvalstatus", typeof(int)); // Add the uploaderuserid column to the DataTable
                    dataTable.Columns.Add("uploadedDate", typeof(DateTime)); // Add the updateddate column to the DataTable
                    dataTable.Columns.Add("approvedDate", typeof(DateTime)); // Add the approveruserid column to the DataTable

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
                            int columnIndex = col;

                            // Find the column index based on the column name in the Excel file
                            for (int i = 1; i <= columnCount; i++)
                            {
                                if (worksheet.Cells[1, i].Value?.ToString() == columnName)
                                {
                                    columnIndex = i;
                                    break;
                                }
                            }

                            if (columnIndex != col)
                            {
                                throw new Exception($"Column '{columnName}' in the Excel file does not exist in the database table.");
                            }

                            dataRow[columnName] = worksheet.Cells[row, columnIndex].Value?.ToString() ?? string.Empty;
                        }

                        dataRow["uploaderUserId"] = uploaderUserId;
                        dataRow["approverUserId"] = approverUserId;
                        dataRow["approvalstatus"] = approvalstatus;
                        dataRow["uploadedDate"] = updatedDate;
                        dataRow["approvedDate"] = updatedDate;

                        dataTable.Rows.Add(dataRow);
                    }

                    // Save DataTable to database, excluding the 'id' column
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                        {
                            bulkCopy.DestinationTableName = destinationTable;
                            bulkCopy.ColumnMappings.Clear();

                            // Exclude the 'id' column from the bulk copy operation
                            for (int col = 1; col <= columnCount; col++)
                            {
                                string columnName = dataTable.Columns[col - 1].ColumnName;
                                if (!columnName.Equals("Id", StringComparison.OrdinalIgnoreCase))
                                    bulkCopy.ColumnMappings.Add(columnName, columnName);
                            }
                            // Include mappings for the missing fields
                            bulkCopy.ColumnMappings.Add("uploaderUserId", "uploaderUserId");
                            bulkCopy.ColumnMappings.Add("approverUserId", "approverUserId");
                            bulkCopy.ColumnMappings.Add("approvalstatus", "approvalstatus");
                            bulkCopy.ColumnMappings.Add("uploadedDate", "uploadedDate");
                            bulkCopy.ColumnMappings.Add("approvedDate", "approvedDate");

                            connection.Open();
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
