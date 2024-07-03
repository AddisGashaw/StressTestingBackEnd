using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RauserProfile
{
    public int Id { get; set; }

    public string? UserEmail { get; set; }

    public string? EmployeeId { get; set; }

    public int? UserRoleId { get; set; }

    public int? DepartmentId { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public string? History { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual Radepartment? Department { get; set; }

    public virtual Role? UserRole { get; set; }
}
