global using RiskAppetite.Models.Dto;
using Cbe.MiddleWare;
using CBE_ERMS.Configuration;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using RiskAppetite.Controllers.AnalysisControllers;
using RiskAppetite.Models;
using RiskAppetite.Services.AnalysisServices.Assumption;
using RiskAppetite.Services.AnalysisServices.ShareAndGrowth;
using RiskAppetite.Services.ExcelUpload;
using RiskAppetite.Services.RoleAssignation;
using RiskAppetite.Services.SeverityService;
using RiskAppetite.Services.UserProfileService;

var builder = WebApplication.CreateBuilder(args);
//lets tell about the connection string that we have created in appsetting.json
var constring = builder.Configuration.GetConnectionString("cbe_Risk_Apetite");
builder.Services.AddDbContext<RiskApetiteContext>(options => options.UseSqlServer(constring));
//end
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MapperConfig));
// Add services to the container.
builder.Services.AddScoped<IRoleAssignation, RoleAssignation>();
builder.Services.AddScoped<IExcelUpload, ExcelUpload>();
builder.Services.AddScoped<IUserProfile, UserProfileSer>();
builder.Services.AddScoped<IShareAndGrowth, ShareAndGrowthClass>();
builder.Services.AddScoped<IShareAndGrowth_SEB, ShareAndGrowth_SEB>();
builder.Services.AddScoped<ISeverity, SeverityClass>();
builder.Services.AddScoped<IAssumption, Assumption>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
});
app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
