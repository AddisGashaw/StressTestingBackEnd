using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RariskLevel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Value { get; set; }

    public int? Status { get; set; }

    public string? History { get; set; }

    public string? Description { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<RariskLevelCorporate> RariskLevelCorporates { get; set; } = new List<RariskLevelCorporate>();
}
