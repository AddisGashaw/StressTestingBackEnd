using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class UserProfile
{
    public int Id { get; set; }

    public string? UserEmail { get; set; }

    public string? EmployeeId { get; set; }

    public int? UserRoleId { get; set; }

    public virtual ICollection<Severity> Severities { get; set; } = new List<Severity>();

    public virtual ICollection<SeverityForAnalysis> SeverityForAnalyses { get; set; } = new List<SeverityForAnalysis>();

    public virtual Role? UserRole { get; set; }
}
