using Microsoft.AspNetCore.Mvc;

namespace RiskAppetite.Services.ExcelUpload
{
    public interface IExcelUpload
    {
        Task<string> UploadExcelFile(IFormFile file,string destinationTable, int uploaderUserId);
    }
}
