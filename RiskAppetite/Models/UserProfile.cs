using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class UserProfile
{
    public int Id { get; set; }

    public string? UserEmail { get; set; }

    public string? EmployeeId { get; set; }

    public int? UserRoleId { get; set; }

    public virtual ICollection<Credit> CreditApproverUsers { get; set; } = new List<Credit>();

    public virtual ICollection<Credit> CreditUploaderUsers { get; set; } = new List<Credit>();

    public virtual Role? UserRole { get; set; }
}
