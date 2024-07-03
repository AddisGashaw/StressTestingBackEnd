using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class SebmarketModelEstimation
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public string? CoGdpGrowth { get; set; }

    public string? PtGdpGrowth { get; set; }

    public string? CoRealGdp { get; set; }

    public string? PtRealGdp { get; set; }

    public string? CoInflationChange { get; set; }

    public string? PtInflationChange { get; set; }

    public string? CoInflation { get; set; }

    public string? PtInflation { get; set; }

    public string? CoExport { get; set; }

    public string? PtExport { get; set; }

    public string? CoImport { get; set; }

    public string? PtImport { get; set; }

    public string? CoTradeGr { get; set; }

    public string? PtTradeGr { get; set; }

    public string? CoAverageAnnualExchageRateGr { get; set; }

    public string? PtAverageAnnualExchageRateGr { get; set; }

    public string? CoBroadMoneySupply { get; set; }

    public string? PtBroadMoneySupply { get; set; }

    public string? CoExchangeRateGrowth { get; set; }

    public string? PtExchangeRateGrowth { get; set; }

    public string? CoCurrentAccountBalGr { get; set; }

    public string? PtCurrentAccountBalGr { get; set; }

    public string? CoImportGrowth { get; set; }

    public string? PtImportGrowth { get; set; }

    public string? CoTradeBalanceGrowth { get; set; }

    public string? PtTradeBalanceGrowth { get; set; }

    public string? CoBroadMoneyGrowth { get; set; }

    public string? PtBroadMoneyGrowth { get; set; }

    public string? CoCurrencyOutsideTheBankGrowth { get; set; }

    public string? PtCurrencyOutsideTheBankGrowth { get; set; }

    public string? CoGovernmentExpenditureGrowth { get; set; }

    public string? PtGovernmentExpenditureGrowth { get; set; }

    public string? CoBudgetDeficitGrowth { get; set; }

    public string? PtBudgetDeficitGrowth { get; set; }

    public string? CoLagPd { get; set; }

    public string? PtLagPd { get; set; }

    public string? CoLagDeposit { get; set; }

    public string? PtLagDeposit { get; set; }

    public string? CoLagLoanAndAdvance { get; set; }

    public string? PtLagLoanAndAdvance { get; set; }

    public string? PtLagExchangeRate { get; set; }

    public string? CoLagExchangeRate { get; set; }

    public string? CoNplPoint { get; set; }

    public string? PtNplPoint { get; set; }

    public string? CoConstant { get; set; }

    public string? PtConstant { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? Statuses { get; set; }

    public string? Descriptions { get; set; }

    public string? History { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
