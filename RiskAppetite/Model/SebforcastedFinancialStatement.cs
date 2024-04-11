using System;
using System.Collections.Generic;

namespace RiskAppetite.Model;

public partial class SebforcastedFinancialStatement
{
    public int Id { get; set; }

    public string? ForcastedYear { get; set; }

    public string? ForcastedInterestIncomeLoansAndAdvances { get; set; }

    public string? ForcastedInterestIncomebondsAndSecurities { get; set; }

    public string? ForcastedCommissionAndCharges { get; set; }

    public string? ForcastedCbeNoorIncome { get; set; }

    public string? ForcastedGainOnFx { get; set; }

    public string? ForcastedOtherIncome { get; set; }

    public string? ForcastedInterestExpense { get; set; }

    public string? ForcastedProfitPaidToCbeNoorDeposit { get; set; }

    public string? ForcastedEmployeesSalaries { get; set; }

    public string? ForcastedEmployeesBenefits { get; set; }

    public string? ForcastedEmployeesProvisions { get; set; }

    public string? ForcastedGeneralExpenses { get; set; }

    public string? ForcastedLossOnFx { get; set; }

    public string? ForcastedImpairmentOnFinancialAssets { get; set; }

    public string? ForcastedProfitLossBeforeTaxation { get; set; }

    public string? ForcastedCashAndCashEquivalent { get; set; }

    public string? ForcastedDebtAndEquitySecurities { get; set; }

    public string? ForcastedLoansAdvancesAndFinancingToCustomersNet { get; set; }

    public string? ForcastedLoansToFinancialInstitutions { get; set; }

    public string? ForcastedReceivablesNet { get; set; }

    public string? ForcastedInvestmentsInSubsidiariesAndAssociates { get; set; }

    public string? ForcastedNonCurrentAssetsHeldForSaleNet { get; set; }

    public string? ForcastedPropertyPlantAndEquipmentNet { get; set; }

    public string? ForcastedRightOfUseAssetsNet { get; set; }

    public string? ForcastedIntangibleAssetsSoftwares { get; set; }

    public string? ForcastedOtherAssets { get; set; }

    public string? ForcastedDeferredTaxAsset { get; set; }

    public string? ForcastedDepositsDueToOtherBanks { get; set; }

    public string? ForcastedCustomersDeposit { get; set; }

    public string? ForcastedMarginHeldPayable { get; set; }

    public string? ForcastedTaxAndPensionPayable { get; set; }

    public string? ForcastedFinanceLeaseObligations { get; set; }

    public string? ForcastedDividend { get; set; }

    public string? ForcastedEmployeeBenefitsObligation { get; set; }

    public string? ForcastedProvisions { get; set; }

    public string? ForcastedBorrowingNationalBankLiabilities { get; set; }

    public string? ForcastedOtherLiabilities { get; set; }

    public string? ForcastedCapital { get; set; }

    public string? ForcastedLegalReserve { get; set; }

    public string? ForcastedAccumulatedProfitOrLoss { get; set; }

    public string? ForcastedCbeNoorReserve { get; set; }

    public string? ForcastedOtherComprehensiveIncome { get; set; }

    public string? ForcastedRegulatoryImpairmentReserve { get; set; }

    public string? ForcastedProvisionalProfitLoss { get; set; }

    public string? ForcastedDemandDepositPrivate { get; set; }

    public string? ForcastedDemandDepositPublicEnterprises { get; set; }

    public string? ForcastedDemandDepositAssociations { get; set; }

    public string? ForcastedDemandDepositGovernment { get; set; }

    public string? ForcastedSavingPrivate { get; set; }

    public string? ForcastedSavingPublicEnterprises { get; set; }

    public string? ForcastedSavingAssociations { get; set; }

    public string? ForcastedSavingGovernment { get; set; }

    public string? ForcastedTimePrivate { get; set; }

    public string? ForcastedTimePublicEnterprises { get; set; }

    public string? ForcastedTimeAssociations { get; set; }

    public string? ForcastedTimeGovernment { get; set; }

    public string? ForcastedCbeNoorDeposit { get; set; }

    public string? ForcastedLoansAndAndAdvancePrincipal { get; set; }

    public string? ForcastedAccruedInterestOnLoansAndAdvance { get; set; }

    public string? ForcastedCouponBondPrincipal { get; set; }

    public string? ForcastedAccruedInterestOnCouponBond { get; set; }

    public string? ForcastedDbeBond { get; set; }

    public string? ForcastedAccruedInterestOnDbesBond { get; set; }

    public string? ForcastedGovernmentBond { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
