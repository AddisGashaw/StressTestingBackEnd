using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public string? Description { get; set; }

    public int? Status { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
