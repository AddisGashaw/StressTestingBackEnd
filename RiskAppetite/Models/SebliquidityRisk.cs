using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class SebliquidityRisk
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? OutstandingDeposit { get; set; }

    public string? TotalDemandDeposit { get; set; }

    public string? TotalSavingsDeposit { get; set; }

    public string? TotalFixedDeposit { get; set; }

    public string? TotalCbeNoorDemandDeposit { get; set; }

    public string? TotalCbeNoorSavingDeposit { get; set; }

    public string? TotalCbeNoorFixedDeposit { get; set; }

    public string? OtherLiabilitiesIncludesBorrowingMarginHeldAccountAndOthers { get; set; }

    public string? StableDeposit { get; set; }

    public string? LessStableDeposit { get; set; }

    public string? DepositsHeldAtOtherFinancialInstitutionsForOperationalPurpose { get; set; }

    public string? LoanAndAdvances { get; set; }

    public string? DebtSecuritiesBonds { get; set; }

    public string? EquitySecurityInvestmentOnShares { get; set; }

    public string? InvestmentInSubsidiariesAndAssociates { get; set; }

    public string? OtherAssets { get; set; }

    public string? UndrawnAmountOfCommittedCreditFacilities { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
