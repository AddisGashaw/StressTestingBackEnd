using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class SeverityForAnalysis
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public int? SeverityCatId { get; set; }

    public string? NplGrowth { get; set; }

    public string? NplShare { get; set; }

    public string? InterestRateForLongTermLAndA { get; set; }

    public string? DepositGrowthPerDrawdown { get; set; }

    public string? UnplannedMaterializationOfCommitmentsAdjusted { get; set; }

    public string? TotalNetCurrentLiability { get; set; }

    public string? Top10DepositorsShareFromTotalDeposit { get; set; }

    public string? Top100DepositorsShareFromTotalDeposit { get; set; }

    public string? Top1000DepositorsShareFromTotalDeposit { get; set; }

    public string? Top10DepositorsWithdraw { get; set; }

    public string? Top100DepositorsWithdraw { get; set; }

    public string? Top1000DepositorsWithdraw { get; set; }

    public string? DepositMaturingInTheNextThreeMonths { get; set; }

    public string? ScheduledPayables { get; set; }

    public string? InterestRateIncrease { get; set; }

    public string? InterestRateDecrease { get; set; }

    public string? TheShareOfFcyBsByCuurenyTypeUsd { get; set; }

    public string? DevaluationOfBirrToUsdShareOfTheGapBnOfficialAndParallel { get; set; }

    public string? MidRateGrowthUsdToBirr { get; set; }

    public string? TheIncrementOnTheActualMidRateImpactedByTheAverageGrowthRateAndDevaluation { get; set; }

    public string? CreditConversionFactorForLc { get; set; }

    public string? CreditConversionFactorForGuarantee { get; set; }

    public string? ActualLossPerNearMissLossToAverageOfTheThreeYearsGrossIncomeRatio { get; set; }

    public string? External { get; set; }

    public string? People { get; set; }

    public string? Process { get; set; }

    public string? System { get; set; }

    public string? PrincipalCollectionFromTotalCollection { get; set; }

    public string? InterestCollectionFromTotalCollection { get; set; }

    public string? PrincipalCollectionShareOfBond { get; set; }

    public string? PrincipalCollectionShareOfLoanAndAdvance { get; set; }

    public string? ShareOfNewLoanDisbursmentFromTheTotalDisbursment { get; set; }

    public string? ShareOfFreshBondDisbursmentFromTheTotalDisbursment { get; set; }

    public string? RatioOfPrincipalLoanCollectionToPrincipalLoansAndAdvancesAmount { get; set; }

    public string? ShareOfPrincipalBondCollectionToPrincipalBondAmount { get; set; }

    public string? ShareOfNcsbcFromTheTotalLoan { get; set; }

    public string? LegalReserve { get; set; }

    public string? IncrementalDepositNetOfNonFundImpact { get; set; }

    public string? MaximumFundApplicationRate { get; set; }

    public string? DisburcementShareOfLoan { get; set; }

    public string? DisburcementShareOfBond { get; set; }

    public string? IncrementalIfbDepositShare { get; set; }

    public string? IncrementalConventionalDepositShare { get; set; }

    public string? IncrementalConventionalSavingDepositShare { get; set; }

    public string? IncrementalConventionalTimeDepositShare { get; set; }

    public string? EffectiveInterestRateOfLoan { get; set; }

    public string? EffectiveInterestRateOfBond { get; set; }

    public string? DepositInterestRateForSaving { get; set; }

    public string? DepositInterestRateForTime { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UploaderUserId { get; set; }

    public int? UpdaterUserId { get; set; }

    public int? Status { get; set; }

    public virtual Severity? SeverityCat { get; set; }

    public virtual UserProfile? UploaderUser { get; set; }
}
