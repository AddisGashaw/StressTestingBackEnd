using System;
using System.Collections.Generic;

namespace RiskAppetite.Model;

public partial class SebliquidityRisk
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? TotalDemandDeposit { get; set; }

    public string? TotalSavingsDeposit { get; set; }

    public string? TotalFixedDeposit { get; set; }

    public string? TotalCbeNoorDemandDeposit { get; set; }

    public string? TotalCbeNoorSavingDeposit { get; set; }

    public string? TotalCbeNoorFixedDeposit { get; set; }

    public string? OutstandingDeposit { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
