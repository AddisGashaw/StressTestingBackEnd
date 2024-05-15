using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class MarketRisk
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public string? RateSensitiveAssets { get; set; }

    public string? RateSensitiveLiabilities { get; set; }

    public string? RateSensitiveAssetsThreeMonths { get; set; }

    public string? RateSensitiveLiabilitiesThreeMonths { get; set; }

    public string? FxAssetOnBalanceSheetAssets { get; set; }

    public string? FxAssetOffBalanceSheetAssets { get; set; }

    public string? FxLiabilityOnBalanceSheetLiabilities { get; set; }

    public string? FxLiabilityOffBalanceSheetLiabilities { get; set; }

    public string? AssetByMaturityBucket1Day { get; set; }

    public string? AssetByMaturityBucket27Days { get; set; }

    public string? AssetByMaturityBucket814Days { get; set; }

    public string? AssetByMaturityBucket15DaysTo1Month { get; set; }

    public string? AssetByMaturityBucket13Months { get; set; }

    public string? AssetByMaturityBucket36Months { get; set; }

    public string? AssetByMaturityBucket612Months { get; set; }

    public string? AssetByMaturityBucket13Years { get; set; }

    public string? AssetByMaturityBucketOver3Years { get; set; }

    public string? AssetByMaturityBucketNonInterestSensitiveItems { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket1Day { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket27Days { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket814Days { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket15DaysTo1Month { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket13Months { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket36Months { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket612Months { get; set; }

    public string? LiabilityAndEquaityByMaturityBucket13Years { get; set; }

    public string? LiabilityAndEquaityByMaturityBucketOver3Years { get; set; }

    public string? LiabilityAndEquaityByMaturityBucketNonInterestSensitiveItems { get; set; }

    public string? OpenPositionByUsdShort { get; set; }

    public string? OpenPositionByEurShort { get; set; }

    public string? OpenPositionByOtherCurrencyShort { get; set; }

    public string? OpenPositionByUsdShortExcludingNbe { get; set; }

    public string? OpenPositionByEurShortExcludingNbe { get; set; }

    public string? OpenPositionByEurOtherCurrencyExcludingNbe { get; set; }

    public string? TotalOnBSFcyAssetsUsd { get; set; }

    public string? TotalOnBSFcyAssetsEur { get; set; }

    public string? TotalOnBSFcyAssetsOtherCurrencies { get; set; }

    public string? TotalOnBSFcyLiabilitiesUsd { get; set; }

    public string? TotalOnBSFcyLiabilitiesEur { get; set; }

    public string? TotalOnBSFcyLiabilitiesOtherCurrencies { get; set; }

    public string? TotalOffBSFcyAssetsUsd { get; set; }

    public string? TotalOffBSFcyAssetsEur { get; set; }

    public string? TotalOffBSFcyAssetsOtherCurrencies { get; set; }

    public string? TotalOffBSFcyLiabilitiesUsd { get; set; }

    public string? TotalOfBSFcyLiabilitiesEur { get; set; }

    public string? TotalOffBSFcyLiabilitiesOtherCurrencies { get; set; }

    public string? FcyOnBSAssetsInUsd { get; set; }

    public string? FcyOfBSAssetsInUsd { get; set; }

    public string? FcyOnBSLiabilitiesInUsd { get; set; }

    public string? FcyOffBSLiabilitiesInUsd { get; set; }

    public string? FcyOnBSAssetsInOtherCurrenciesInBirr { get; set; }

    public string? FcyOnBSLiabilitiesInOtherCurrenciesInBirr { get; set; }

    public string? FcyOnBSLetterOfCredit { get; set; }

    public string? FcyOnBSGuarantee { get; set; }

    public string? FcyFcyAssetCashAndDepositByUsd { get; set; }

    public string? FcyCorrespondenOurAccountMillionUsdEquva { get; set; }

    public string? UsdAgenistBirrBuyingRate { get; set; }

    public string? UsdAgenistBirrSellingRate { get; set; }

    public string? UsdAgenistBirrMidRate { get; set; }

    public string? OfficialMarketRate { get; set; }

    public string? ParallelMarketRate { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
