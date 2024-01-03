using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class SebcreditRisk
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? NonPerformingLoanNpl { get; set; }

    public string? Provision { get; set; }

    public string? LoanAndAdavce { get; set; }

    public string? NetCoupon { get; set; }

    public string? NetLoan { get; set; }

    public string? TotalBond { get; set; }

    public string? PerformingLoanAmount { get; set; }

    public string? NcsblPrivateAndCooperatives { get; set; }

    public string? Csbl { get; set; }

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
