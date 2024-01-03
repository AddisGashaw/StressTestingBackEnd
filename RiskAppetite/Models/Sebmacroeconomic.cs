using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Sebmacroeconomic
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Inflation { get; set; }

    public string? AverageAnnualExchageRate { get; set; }

    public string? RealGdp { get; set; }

    public string? Export { get; set; }

    public string? Import { get; set; }

    public string? TradeBalance { get; set; }

    public string? BroadMoneySupply { get; set; }

    public string? CurrencyOutsideTheBank { get; set; }

    public string? GovernmentExpenditure { get; set; }

    public string? BudgetDeficit { get; set; }

    public string? CurrentAccountBalance { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
