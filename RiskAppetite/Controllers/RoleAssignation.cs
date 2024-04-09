using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiskAppetite.Models;
using RiskAppetite.Services.RoleAssignation;

namespace RiskAppetite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleAssignations : ControllerBase
    {
        private readonly IRoleAssignation _roleAssignation;
        private RiskApetiteContext context;
        private IMapper mapper;
        private IMapper @object;

        public RoleAssignations(IRoleAssignation roleAssignation)
        {
            _roleAssignation = roleAssignation;
        }

        public RoleAssignations(RiskApetiteContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public RoleAssignations(IRoleAssignation roleAssignation, IMapper @object) : this(roleAssignation)
        {
            this.@object = @object;
        }

        [HttpPost]
        public async Task<ActionResult> RoleAssignment(UserRoleAssignationDto UserRoleAssignationDto)
        {
            var result = await _roleAssignation.RoleAssignment(UserRoleAssignationDto);
            return Ok(result);
        }

    }
}
