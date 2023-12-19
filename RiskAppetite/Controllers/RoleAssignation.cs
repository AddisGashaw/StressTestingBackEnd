using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Services.RoleAssignation;

namespace RiskAppetite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleAssignation : ControllerBase
    {
        private readonly IRoleAssignation _roleAssignation;

        public RoleAssignation(IRoleAssignation roleAssignation)
        {
            _roleAssignation = roleAssignation;
        }
        [HttpPost]
        public async Task<ActionResult> RoleAssignment(UserRoleAssignationDto UserRoleAssignationDto)
        {
            var result = await _roleAssignation.RoleAssignment(UserRoleAssignationDto);
            return Ok(result);
        }

    }
}
