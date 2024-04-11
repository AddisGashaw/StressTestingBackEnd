using System;
using System.Collections.Generic;

namespace RiskAppetite.Model;

public partial class SebmarketRisk
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? NetFxPositionMillionUsd { get; set; }

    public string? OnBsAssetsUsdEquivalent { get; set; }

    public string? OnBsLiabilitiesUsdEquivalent { get; set; }

    public string? OnBsAssetsInUsd { get; set; }

    public string? OnBsLiablitiesInUsd { get; set; }

    public string? OnBsAssetsInOtherCurrenciesInBirr { get; set; }

    public string? OnBsLiablitiesInOtherCurrenciesInBirr { get; set; }

    public string? OffBalanceSheetFxPosition { get; set; }

    public string? OffBsAsset { get; set; }

    public string? OffBsLiablities { get; set; }

    public string? TotalOnBsFcyAssetsUsd { get; set; }

    public string? TotalOnBsFcyAssetsOtherCurrencies { get; set; }

    public string? TotalOnBsFcyLiabilityUsd { get; set; }

    public string? TotalOnBsFcyLiabilityOtherCurrencies { get; set; }

    public string? OpenPositionUsdShort { get; set; }

    public string? OpenPositionOtherCurrencyShort { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
