using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RiskAppetite.Models;
using RiskAppetite.Models.Dto;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly RiskApetiteContext _context;
    private readonly IMapper _mapper;

    public AuthController(RiskApetiteContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [AllowAnonymous]
    [HttpPost("login")]
    public ActionResult Login([FromBody] UserLoginRequestDto model)
    {
        //if (_context.UserProfiles.Any(u => u.UserEmail == model.UserName))
            using (var entry = new DirectoryEntry("LDAP://10.1.11.13"))
        {
            var username = model.UserName;
            var password = model.Password;

            // Set the username and password for authentication
            entry.Username = username;
            entry.Password = password;
            Console.WriteLine();
            try
            {
                // Attempt to bind with the provided credentials
                using (var searcher = new DirectorySearcher(entry))
                {
                    if (searcher!=null)
                    {
                        searcher.Filter = $"(&(objectClass=user)(mailnickname={username}))";
                        searcher.PropertiesToLoad.AddRange(new[] { "displayName", "name", "givenname", "memberof", "mailnickname", "mail", "employeeID", "department", "title" });

                        var result = searcher.FindOne();

                        if (result != null)
                        {
                            var displayName = result.Properties["displayName"][0].ToString();
                            var email = result.Properties["mail"][0].ToString();
                            var employeeId = result.Properties["employeeID"][0].ToString();
                            var department = result.Properties["department"][0].ToString();
                            var title = result.Properties["title"][0].ToString();
                            var name = result.Properties["name"][0].ToString();
                            var givenname = result.Properties["givenname"][0].ToString();
                            var memberof = result.Properties["memberof"][0].ToString();
                            var mailnickname = result.Properties["mailnickname"][0].ToString();

                            if (_context.UserProfiles.Any(u => u.EmployeeId == employeeId || u.UserEmail == email))
                            {
                                var role = _context.UserProfiles.Where(u => u.EmployeeId == employeeId || u.UserEmail == email).Select(u => u.UserRoleId).FirstOrDefault().ToString();
                                var UserId = _context.UserProfiles.Where(u => u.EmployeeId == employeeId || u.UserEmail == email).Select(u => u.Id).FirstOrDefault().ToString();
                                var token = GenerateJwtToken(displayName, employeeId, department, email, name, mailnickname, role, UserId);

                                return Ok(new { token = token, displayName = displayName });

                                //return Ok($"Authenticated successfully\nDisplay Name: {displayName}\nEmail: {email}\nEmployee ID: {employeeId}\nTitle: {title}\nDepartment: {department}\nname: {name}\ngivenname: {givenname}\nmemberof: {memberof}\nmailnickname: {mailnickname}\nToken: {token}");
                            }
                            return NotFound("You have not the access to this system, please contact addisgashaw@cbe.com.et");

                        }
                        else
                        {
                            // User not found
                            return NotFound();
                        }
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
            }
            catch (DirectoryServicesCOMException)
            {
                // Authentication failed
                return Unauthorized("Email or Password is Incorrect");
            }
        }


    }
    private string GenerateJwtToken(string displayName, string employeeId, string department,string email,string name,string mailnickname,string role,string UserId)
    {
        // Set the secret key used for signing the token
        //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key_here"));
        byte[] keyBytes = new byte[32]; // 256 bits
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(keyBytes);
        }

        // Create a symmetric security key using the generated key
        var key = new SymmetricSecurityKey(keyBytes);

        // Create signing credentials using the key
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        

        // Set the claims for the token (e.g., username)
        var claims = new[]
    {
        new Claim(ClaimTypes.Name, displayName),
        new Claim("EmployeeId", employeeId),
        new Claim("Department", department), // Custom claim for department
        new Claim("mailnickname", mailnickname), 
        new Claim("name", name), 
        new Claim("email", email), 
        new Claim("role", role) ,
        new Claim("UserId", UserId)
    };

        // Set token options
        var tokenOptions = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.UtcNow.AddHours(12), // Set token expiration time
            signingCredentials: credentials
        );

        // Generate the token
        var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        return token;
    }
    [HttpGet("GetRoleList")]
    public async Task<ActionResult<IEnumerable<userRoleListDto>>> GetUserRole()
    {
        if (_context.Roles == null)
        {
            return NotFound();
        }
        var RolesList = _mapper.Map<IEnumerable<userRoleListDto>>(await _context.Roles.ToListAsync());
        return Ok(RolesList);
    }
    
}