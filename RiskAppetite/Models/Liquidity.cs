using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Liquidity
{
    public int Id { get; set; }

    public string? ParamLiq { get; set; }

    public string? ParamLiq2 { get; set; }

    public string? ParamLiq3 { get; set; }

    public string? ParamLiq4 { get; set; }

    public string? ParamLiq5 { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
