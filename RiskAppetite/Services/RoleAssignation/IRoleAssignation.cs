namespace RiskAppetite.Services.RoleAssignation
{
    public interface IRoleAssignation
    {
        Task<UserRoleAssignationDto> RoleAssignment(UserRoleAssignationDto UserRoleAssignationDto);

    }
}
