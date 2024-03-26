using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Sdbcredit
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public string? PassLoan { get; set; }

    public string? SpecialMentionLoan { get; set; }

    public string? SubstandardLoan { get; set; }

    public string? DoubtfulLoan { get; set; }

    public string? LossLoan { get; set; }

    public string? TotalBondsCorpAndCoup { get; set; }

    public string? NplAgriculture { get; set; }

    public string? NplIndustries { get; set; }

    public string? NplDomesticTradeAndService { get; set; }

    public string? NplInternationalTrade { get; set; }

    public string? NplBuildingAndConstruction { get; set; }

    public string? NplConsumerLoan { get; set; }

    public string? NplFinancialInstitutions { get; set; }

    public string? NplOtherSector { get; set; }

    public string? RecoveryRate1 { get; set; }

    public string? RecoveryRate2 { get; set; }

    public string? RecoveryRate3 { get; set; }

    public string? ProvisionForPass { get; set; }

    public string? ProvisionForSpecialMention { get; set; }

    public string? ProvisionForSubstandard { get; set; }

    public string? ProvisionForDoubtful { get; set; }

    public string? ProvisionForLoss { get; set; }

    public string? Top10BorrowersOOrs { get; set; }

    public string? Top100BorrowersOOrs { get; set; }

    public string? RiskWeightedAsset { get; set; }

    public string? Csbl { get; set; }

    public string? NcsblPrivAndCoop { get; set; }

    public string? TotalDisbursement { get; set; }

    public string? PrincipalCollectionLoansAndAdvances { get; set; }

    public string? PrincipalCollectionCoupAndCorpBonds { get; set; }

    public string? PrincipalCollectionActual { get; set; }

    public string? DisbursementLoansAdv { get; set; }

    public string? DisbursementCouponCorporateBonds { get; set; }

    public string? TotalInterestEarnedLoansAndAdv { get; set; }

    public string? TotalIncomeCbeNoorFinancing { get; set; }

    public string? LetterOfCredit { get; set; }

    public string? LoansAndBondCom { get; set; }

    public string? LoansAndBondComGuarantedByCentralGov { get; set; }

    public string? LoansComGuarnateedByRegionalGov { get; set; }

    public string? BidBondsPerformanceBonds { get; set; }

    public string? TotalOffBSheetRwa { get; set; }

    public string? AdjustedCommitment { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
