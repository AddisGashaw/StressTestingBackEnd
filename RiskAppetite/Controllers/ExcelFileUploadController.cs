using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Services.ExcelUpload;

namespace RiskAppetite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelFileUploadController : ControllerBase
    {
        private readonly IExcelUpload _excelUpload;

        public ExcelFileUploadController(IExcelUpload excelUpload)
        {
            _excelUpload = excelUpload;
        }
        [HttpPost("UploadExcel")]
        public async Task<IActionResult> UploadExcelFile(IFormFile file, string destinationTable, int uploaderUserId)
        {
            var result = await _excelUpload.UploadExcelFile(file, destinationTable, uploaderUserId);
            return Ok("SUCCESSFULLY UPLOADED");
        }
    }
}
