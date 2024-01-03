namespace RiskAppetite.Models.Dto.UserProfileDto
{
    public class userProfileReadOnlyDto
    {
        public int Id { get; set; }

        public string UserEmail { get; set; }

        public string EmployeeId { get; set; }

        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }

    }
}
