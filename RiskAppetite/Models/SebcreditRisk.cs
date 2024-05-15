using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class SebcreditRisk
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? NonPerformingLoanNpl { get; set; }

    public string? Provision { get; set; }

    public string? LoanAndAdvance { get; set; }

    public string? NetCoupon { get; set; }

    public string? NetLoan { get; set; }

    public string? TotalBond { get; set; }

    public string? NcsblPrivateAndCooperatives { get; set; }

    public string? Csbl { get; set; }

    public string? TotalOffBsCommit { get; set; }

    public string? LetterOfCredit { get; set; }

    public string? LoansAndBondCom { get; set; }

    public string? LoansAndBondComGuarantedByCentralGov { get; set; }

    public string? LoansComGuarnateedByRegionalGov { get; set; }

    public string? BidBondsPerformanceBonds { get; set; }

    public string? TotalInterestEarnedLoansAndAdvance { get; set; }

    public string? TotalIncomeCbeNoorFinancing { get; set; }

    public string? TotalRiskWeightedAssetRwa { get; set; }

    public string? IncreaseInDepositNetOfReserveReqmtAndNonFundInflows { get; set; }

    public string? PrincipalCollectionLoansAndAdvances { get; set; }

    public string? PrincipalCollectionCoupAndCorpBonds { get; set; }

    public string? DisbursementLoansAndAdv { get; set; }

    public string? DisbursementCouponAndCorporateBonds { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
