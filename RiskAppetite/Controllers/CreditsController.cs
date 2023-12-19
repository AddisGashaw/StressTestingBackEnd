using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using RiskAppetite.Models;
using RiskAppetite.Services.ExcelUpload;

namespace RiskAppetite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditsController : ControllerBase
    {
        private readonly RiskApetiteContext _context;
        private readonly IExcelUpload _excelUpload;

        public CreditsController(RiskApetiteContext context,IExcelUpload excelUpload)
        {
            _context = context;
            _excelUpload = excelUpload;
        }

        #region commented file excel upload
        //public async Task<IActionResult> UploadExcelFile(IFormFile file)
        //{
        //    try
        //    {
        //        if (file == null || file.Length <= 0)
        //            return BadRequest("Invalid file");

        //        if (!Path.GetExtension(file.FileName).Equals(".xlsx", System.StringComparison.OrdinalIgnoreCase))
        //            return BadRequest("Invalid file format. Only Excel files are supported.");

        //        using (var stream = new MemoryStream())
        //        {
        //            await file.CopyToAsync(stream);
        //            using (var package = new ExcelPackage(stream))
        //            {
        //                var worksheet = package.Workbook.Worksheets[0]; // Assuming data is on the first sheet
        //                var rowCount = worksheet.Dimension.Rows;
        //                var columnCount = worksheet.Dimension.Columns;

        //                DataTable dataTable = new DataTable();

        //                dataTable.Columns.Add("Id", typeof(int)); // Add the Id column to the DataTable

        //                // Create columns in DataTable
        //                for (int col = 1; col <= columnCount; col++)
        //                {
        //                    dataTable.Columns.Add(worksheet.Cells[1, col].Value.ToString());
        //                }

        //                // Add rows to DataTable with generated IDs
        //                for (int row = 2; row <= rowCount; row++)
        //                {
        //                    DataRow dataRow = dataTable.NewRow();
        //                    dataRow["Id"] = GetNextIdFromDatabase(); // Generate a unique ID for each record
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
        //                        bulkCopy.DestinationTableName = "credit";
        //                        connection.Open();
        //                        bulkCopy.WriteToServer(dataTable);
        //                        connection.Close();
        //                    }
        //                }
        //            }
        //        }

        //        return Ok("Data imported successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred: {ex.Message}");
        //    }
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

        #endregion
        //[HttpPost("UploadExcel")]
        //public async Task<IActionResult> UploadExcelFile(IFormFile file, string destinationTable)
        //{
        //    var result = await _excelUpload.UploadExcelFile(file, destinationTable);
        //    return Ok("SUCCESSFULLY UPLOADED");
        //}
        // GET: api/Credits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Credit>>> GetCredits()
        {
          if (_context.Credits == null)
          {
              return NotFound();
          }
            return await _context.Credits.ToListAsync();
        }

        // GET: api/Credits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Credit>> GetCredit(int id)
        {
          if (_context.Credits == null)
          {
              return NotFound();
          }
            var credit = await _context.Credits.FindAsync(id);

            if (credit == null)
            {
                return NotFound();
            }

            return credit;
        }

        // PUT: api/Credits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCredit(int id, Credit credit)
        {
            if (id != credit.Id)
            {
                return BadRequest();
            }

            _context.Entry(credit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreditExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Credits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Credit>> PostCredit(Credit credit)
        {
          if (_context.Credits == null)
          {
              return Problem("Entity set 'RiskApetiteContext.Credits'  is null.");
          }
            _context.Credits.Add(credit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCredit", new { id = credit.Id }, credit);
        }

        // DELETE: api/Credits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCredit(int id)
        {
            if (_context.Credits == null)
            {
                return NotFound();
            }
            var credit = await _context.Credits.FindAsync(id);
            if (credit == null)
            {
                return NotFound();
            }

            _context.Credits.Remove(credit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CreditExists(int id)
        {
            return (_context.Credits?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
