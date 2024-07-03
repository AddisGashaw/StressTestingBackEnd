using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Radepartment
{
    public int Id { get; set; }

    public string? DepartmentName { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public string? History { get; set; }

    public virtual ICollection<RauserProfile> RauserProfiles { get; set; } = new List<RauserProfile>();
}
