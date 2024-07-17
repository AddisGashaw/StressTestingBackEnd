using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class SdbactualFinancialStatement
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public string? LoansAndAdvancesInterestIncome { get; set; }

    public string? BondsAndSecuritiesInterestIncome { get; set; }

    public string? CommissionAndChargesIncome { get; set; }

    public string? CbeNoorIncome { get; set; }

    public string? GainOnFx { get; set; }

    public string? OtherIncome { get; set; }

    public string? InterestExpense { get; set; }

    public string? ProfitPaidCbeNoorDeposit { get; set; }

    public string? EmployeesSalaries { get; set; }

    public string? EmployeesBenefits { get; set; }

    public string? EmployeesProvissions { get; set; }

    public string? GeneralExpenses { get; set; }

    public string? LossOnFx { get; set; }

    public string? ImpairmrntOnFinancialAssets { get; set; }

    public string? ProfitLossBeforeTaxation { get; set; }

    public string? CashAndCashEquivalent { get; set; }

    public string? DebtAndEquitySecurities { get; set; }

    public string? LoansAdvancesAndFinancingToCustomersNet { get; set; }

    public string? LoansToFinancialInstitutions { get; set; }

    public string? ReceivablesNet { get; set; }

    public string? InvestmentsInSubsidiariesAndAssociates { get; set; }

    public string? NonCurrentAssetsHeldForSaleNet { get; set; }

    public string? PropertyPlantAndEquipmentNet { get; set; }

    public string? RightOfUseAssetsNet { get; set; }

    public string? IntangibleAssetsSoftwares { get; set; }

    public string? OtherAssets { get; set; }

    public string? DeferredTaxAsset { get; set; }

    public string? DepositsDueToOtherBanks { get; set; }

    public string? CustomersDeposits { get; set; }

    public string? MarginHeldPayable { get; set; }

    public string? TaxAndPensionPayable { get; set; }

    public string? FinanceLeaseObligations { get; set; }

    public string? Dividend { get; set; }

    public string? EmployeeBenefitsObligation { get; set; }

    public string? Provisions { get; set; }

    public string? BorrowingNationalBankLiabilities { get; set; }

    public string? OtherLiabilities { get; set; }

    public string? Equity { get; set; }

    public string? Capital { get; set; }

    public string? LegalReserve { get; set; }

    public string? AccumulatedProfitOrLoss { get; set; }

    public string? CbeNoorReserve { get; set; }

    public string? OtherComprehensiveIncome { get; set; }

    public string? RegulatoryImpairmentReserve { get; set; }

    public string? ProvisionalProfitLoss { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
