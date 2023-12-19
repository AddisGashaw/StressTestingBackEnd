using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using RiskAppetite.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Azure.Core;
using Cbe.DomainException;

namespace RiskAppetite.Services.RoleAssignation
{
    public class RoleAssignation : IRoleAssignation
    {
        private readonly RiskApetiteContext _context;
        private readonly IMapper _mapper;

        public RoleAssignation(RiskApetiteContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserRoleAssignationDto> RoleAssignment(UserRoleAssignationDto UserRoleAssignationDto)
        {
          
    
            if (_context.UserProfiles.Any(u => u.EmployeeId == UserRoleAssignationDto.EmployeeId || u.UserEmail== UserRoleAssignationDto.UserEmail))
            {
                throw new DataNotFoundException("User Already exists.");
            }
            var AssignedUser = _mapper.Map<UserProfile>(UserRoleAssignationDto);
            await _context.UserProfiles.AddAsync(AssignedUser);
            await _context.SaveChangesAsync();
            return UserRoleAssignationDto;
        }
    }
}
