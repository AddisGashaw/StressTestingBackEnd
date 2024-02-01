using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Severity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Value { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }

    public virtual UserProfile? CreatedByNavigation { get; set; }

    public virtual ICollection<SeverityForAnalysis> SeverityForAnalyses { get; set; } = new List<SeverityForAnalysis>();
}
