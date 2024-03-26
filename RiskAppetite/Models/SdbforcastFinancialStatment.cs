using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class SdbforcastFinancialStatment
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public string? LoansAndAdvances { get; set; }

    public string? BondsAndSecurities { get; set; }

    public string? CommissionAndCharges { get; set; }

    public string? CbeNoorIncome { get; set; }

    public string? GainOnFx { get; set; }

    public string? OtherIncome { get; set; }

    public string? InterestExpense { get; set; }

    public string? ProfitPaidToCbeNoorDeposit { get; set; }

    public string? EmployeeSalary { get; set; }

    public string? EmployeeBenefit { get; set; }

    public string? EmployeeProvisions { get; set; }

    public string? GeneralExpenses { get; set; }

    public string? LossOnFx { get; set; }

    public string? ImpairmentOnFinancialAssets { get; set; }

    public string? CashAndCashEquivalent { get; set; }

    public string? DebtAndEquitySecurities { get; set; }

    public string? LoansAdvancesAndFinancingCustomerNet { get; set; }

    public string? LoansToFinancialInstitutions { get; set; }

    public string? RecievablesNet { get; set; }

    public string? InvestmentInSubsidariesAndAssociates { get; set; }

    public string? NonCurrentAssetHeldForSaleNet { get; set; }

    public string? PropertyPlantAndEquipmentNet { get; set; }

    public string? RightOfUseAssetsNet { get; set; }

    public string? IntangibleAssetsSoftwares { get; set; }

    public string? OtherAssets { get; set; }

    public string? DeferredTaxAssets { get; set; }

    public string? DepositsDueToOtherBanks { get; set; }

    public string? CustomersDeposit { get; set; }

    public string? MarginHeldPayable { get; set; }

    public string? TaxAndPensionPayable { get; set; }

    public string? FinanceLeaseObligations { get; set; }

    public string? Dividend { get; set; }

    public string? EmployeeBenefitsObligation { get; set; }

    public string? Provisions { get; set; }

    public string? BorrowingNbeLiablities { get; set; }

    public string? OtherLiablities { get; set; }

    public string? Capital { get; set; }

    public string? LegalReserve { get; set; }

    public string? AccumulatedProfitOrLoss { get; set; }

    public string? CbeNoorReserve { get; set; }

    public string? OtherComprhensiveIncome { get; set; }

    public string? RegulatoryImpairmentReserve { get; set; }

    public string? ProvsionalProfitLoss { get; set; }

    public string? Coffee { get; set; }

    public string? LeatherAndLeatherProducts { get; set; }

    public string? OilSeeds { get; set; }

    public string? GarmentAndTextile { get; set; }

    public string? OtherExports { get; set; }

    public string? PrivateTransfers { get; set; }

    public string? WesternUnion { get; set; }

    public string? Transfast { get; set; }

    public string? Atlantic { get; set; }

    public string? MoneyGram { get; set; }

    public string? Dhabshil { get; set; }

    public string? WorldRemit { get; set; }

    public string? CashExpress { get; set; }

    public string? OtherRemitance { get; set; }

    public string? Swift { get; set; }

    public string? WfpOfficialTransfers { get; set; }

    public string? UndpOfficialTransfers { get; set; }

    public string? UnicefOfficialTransfers { get; set; }

    public string? OtherOfficialTransfers { get; set; }

    public string? AirlinesService { get; set; }

    public string? EfpcoService { get; set; }

    public string? TelecomService { get; set; }

    public string? EmbassiesAndOthers { get; set; }

    public string? AtmPurchase { get; set; }

    public string? PosCashAdvance { get; set; }

    public string? BranchWPurchase { get; set; }

    public string? TransferFromNbe { get; set; }

    public string? PublicSectorFcy { get; set; }

    public string? PrivateSectorFcy { get; set; }

    public string? PrivateDemand { get; set; }

    public string? PublicEnterpriseDemand { get; set; }

    public string? AssociationsDemand { get; set; }

    public string? GovernmentDemand { get; set; }

    public string? PrivateSaving { get; set; }

    public string? PublicEnterpriseSaving { get; set; }

    public string? AssociationsSaving { get; set; }

    public string? GovernmentSaving { get; set; }

    public string? PrivateTime { get; set; }

    public string? PublicEnterpriseTime { get; set; }

    public string? AssociationsTime { get; set; }

    public string? GovernmentTime { get; set; }

    public string? PrivateTotalDepositByOwnership { get; set; }

    public string? PublicEnterpriseTotalDepositByOwnership { get; set; }

    public string? AssociationsTotalDepositByOwnership { get; set; }

    public string? GovernmentTotalDepositByOwnership { get; set; }

    public string? TotalCollection { get; set; }

    public string? TotalDisbursment { get; set; }

    public string? BusinessProfitTax { get; set; }

    public string? DividendPayment { get; set; }

    public string? OtherPayableToNbe { get; set; }

    public string? DbeBondPurchase { get; set; }

    public string? LiquidityBuildUp { get; set; }

    public string? LoansAndAdvancePrincipal { get; set; }

    public string? AccruedInterestOnLoansAndAdvance { get; set; }

    public string? CouponBondPrincipal { get; set; }

    public string? AccruedInterestOnCouponBond { get; set; }

    public string? DbeBond { get; set; }

    public string? AccruedInterestOnDbeBond { get; set; }

    public string? GovernmentBond { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
