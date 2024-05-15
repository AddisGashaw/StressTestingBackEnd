using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Sdbliquidity
{
    public int IdNo { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public string? CustomerDeposit { get; set; }

    public string? SavingDeposit { get; set; }

    public string? TimeDeposit { get; set; }

    public string? DemandDeposit { get; set; }

    public string? IfbDeposit { get; set; }

    public string? PrincipalCashCollection { get; set; }

    public string? InterestCashCollection { get; set; }

    public string? LoanPrincipalCashCollection { get; set; }

    public string? LoanInterestCashCollection { get; set; }

    public string? BondPrincipalCashCollection { get; set; }

    public string? BondInterestCashCollection { get; set; }

    public string? TotalAsset { get; set; }

    public string? AssetsMaturingWithinThreeMonths { get; set; }

    public string? AssetsMaturingWithinSixMonths { get; set; }

    public string? AssetsMaturingWithinOneYear { get; set; }

    public string? AssetsMaturingWithinThreeMonthsCashAndBalanceWithNbe { get; set; }

    public string? AssetsMaturingWithinThreeMonthsDebitAndEquitySecurities { get; set; }

    public string? AssetsMaturingWithinThreeMonthsLoanAndAdvanceToCustomers { get; set; }

    public string? AssetsMaturingWithinThreeMonthsLoanAndFinancialInstitutions { get; set; }

    public string? AssetsMaturingWithin3To6Month { get; set; }

    public string? AssetsMaturingWithin6To12Month { get; set; }

    public string? AssetsMaturingWithin1To3Years { get; set; }

    public string? AssetsMaturingOver3Years { get; set; }

    public string? NonMaturingAssets { get; set; }

    public string? TotalLiquidAsset { get; set; }

    public string? Borrowing { get; set; }

    public string? OtherLiablity { get; set; }

    public string? LiablityMaturingWithinThreeMonths { get; set; }

    public string? LiablityMaturingWithinSixMonths { get; set; }

    public string? LiablityMaturingWithinOneYear { get; set; }

    public string? LiabilitiesMaturingWithinThreeMonthDepositDueToOtherBanks { get; set; }

    public string? LiabilitiesMaturingWithinThreeMonthCustomersDeposit { get; set; }

    public string? LiabilitiesMaturingWithinThreeMonthOtherLiabilities { get; set; }

    public string? LiabilitiesMaturingWithin3To6Month { get; set; }

    public string? LiabilitiesMaturingWithin6To12Month { get; set; }

    public string? LiabilitiesMaturingWithin1To3Years { get; set; }

    public string? LiabilitiesMaturingWithinOver3Years { get; set; }

    public string? NonMaturingLiabilities { get; set; }

    public string? Hqla { get; set; }

    public string? TotalLiability { get; set; }

    public string? TotalNetCurrentLiablity { get; set; }

    public string? Top10Depositors { get; set; }

    public string? Top100Depositors { get; set; }

    public string? Top1000Depositors { get; set; }

    public string? TotalCapitalForForexFromOpenPosition { get; set; }

    public string? TotalCapitalForCarFromFs { get; set; }

    public string? Government { get; set; }

    public string? Private { get; set; }

    public string? Publice { get; set; }

    public string? Individual { get; set; }

    public string? Cooperative { get; set; }

    public string? TotalCapital { get; set; }

    public string? ProvisionalProfitPerLoss { get; set; }

    public string? IncreaseInDepositOrNetOfReserveReqmtAndNonFundInflows { get; set; }

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
