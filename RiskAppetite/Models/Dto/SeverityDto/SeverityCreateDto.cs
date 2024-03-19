using System.Text.Json.Serialization;

namespace RiskAppetite.Models.Dto.SeverityDto
{
    public class SeverityCreateDto
    {
        [JsonPropertyName("Year")]
        public string? Year { get; set; }
        [JsonPropertyName("Quarter")]
        public string? Quarter { get; set; }

        public int? SeverityCatId { get; set; }
        [JsonPropertyName("Severity Type")]
        public string SeverityType { get; set; }
        [JsonPropertyName("NPL Growth")]
        public string? NplGrowth { get; set; }
        [JsonPropertyName("NPL Share")]
        public string? NplShare { get; set; }
        [JsonPropertyName("Interest Rate for long term L&A")]
        public string? InterestRateForLongTermLAndA { get; set; }
        [JsonPropertyName("Deposit Growth/ Drawdown")]
        public string? DepositGrowthPerDrawdown { get; set; }
        [JsonPropertyName("Unplanned Materialization of Commitments (Adjusted)")]
        public string? UnplannedMaterializationOfCommitmentsAdjusted { get; set; }
        [JsonPropertyName("Total Net Current Liability")]
        public string? TotalNetCurrentLiability { get; set; }
        [JsonPropertyName("Top 10 Depositors Share from Total Deposit")]
        public string? Top10DepositorsShareFromTotalDeposit { get; set; }
        [JsonPropertyName("Top 100 Depositors Share from Total Deposit")]

        public string? Top100DepositorsShareFromTotalDeposit { get; set; }
        [JsonPropertyName("Top 1000 Depositors Share from Total Deposit")]

        public string? Top1000DepositorsShareFromTotalDeposit { get; set; }
        [JsonPropertyName("Top 10 Depositors withdraw")]

        public string? Top10DepositorsWithdraw { get; set; }
        [JsonPropertyName("Top 100 Depositors withdraw")]

        public string? Top100DepositorsWithdraw { get; set; }
        [JsonPropertyName("Top 1000 Depositors withdraw")]
        public string? Top1000DepositorsWithdraw { get; set; }
        [JsonPropertyName("Deposit maturing in the next three months")]
        public string? DepositMaturingInTheNextThreeMonths { get; set; }
        [JsonPropertyName("Scheduled Payables")]
        public string? ScheduledPayables { get; set; }
        [JsonPropertyName("Interest Rate Increase")]
        public string? InterestRateIncrease { get; set; }
        [JsonPropertyName("Interest Rate Decrease")]
        public string? InterestRateDecrease { get; set; }
        [JsonPropertyName("The share of FCY B/S by Cuureny Type (USD)")]
        public string? TheShareOfFcyBsByCuurenyTypeUsd { get; set; }
        [JsonPropertyName("Devaluation of Birr to USD (Share of the gap b/n official & Parallel)")]
        public string? DevaluationOfBirrToUsdShareOfTheGapBnOfficialAndParallel { get; set; }
        [JsonPropertyName("Mid Rate Growth (USD to Birr)")]

        public string? MidRateGrowthUsdToBirr { get; set; }
        [JsonPropertyName("The increment on the actual mid rate impacted by the average growth rate and devaluation")]
        public string? TheIncrementOnTheActualMidRateImpactedByTheAverageGrowthRateAndDevaluation { get; set; }
        [JsonPropertyName("Credit conversion factor for LC")]

        public string? CreditConversionFactorForLc { get; set; }
        [JsonPropertyName("Credit conversion factor for Guarantee ")]

        public string? CreditConversionFactorForGuarantee { get; set; }
        [JsonPropertyName("Actual loss/near miss loss to average of the three years gross income ratio")]
        public string? ActualLossPerNearMissLossToAverageOfTheThreeYearsGrossIncomeRatio { get; set; }
        [JsonPropertyName("External")]
        public string? External { get; set; }
        [JsonPropertyName("People")]

        public string? People { get; set; }
        [JsonPropertyName("Process")]

        public string? Process { get; set; }
        [JsonPropertyName("System")]

        public string? System { get; set; }
        [JsonPropertyName("Principal collection from total collection")]

        public string? PrincipalCollectionFromTotalCollection { get; set; }
        [JsonPropertyName("Interest collection from total collection")]

        public string? InterestCollectionFromTotalCollection { get; set; }
        [JsonPropertyName("Principal Collection share of bond")]

        public string? PrincipalCollectionShareOfBond { get; set; }
        [JsonPropertyName("Principal Collection share of Loan & Advance")]

        public string? PrincipalCollectionShareOfLoanAndAdvance { get; set; }
        [JsonPropertyName("Share of new loan disbursment from the total disbursment")]

        public string? ShareOfNewLoanDisbursmentFromTheTotalDisbursment { get; set; }
        [JsonPropertyName("Share of fresh bond disbursment from the total disbursment")]

        public string? ShareOfFreshBondDisbursmentFromTheTotalDisbursment { get; set; }
        [JsonPropertyName("Ratio of Principal loan collection to principal Loans & Advances Amount")]

        public string? RatioOfPrincipalLoanCollectionToPrincipalLoansAndAdvancesAmount { get; set; }
        [JsonPropertyName("Share of Principal bond collection to principal bond Amount")]

        public string? ShareOfPrincipalBondCollectionToPrincipalBondAmount { get; set; }
        [JsonPropertyName("Share of NCSBC from the total loan ")]

        public string? ShareOfNcsbcFromTheTotalLoan { get; set; }
        [JsonPropertyName("Legal Reserve ")]
        public string? LegalReserve { get; set; }
        [JsonPropertyName("Incremental deposit net of non-fund Impact")]

        public string? IncrementalDepositNetOfNonFundImpact { get; set; }
        [JsonPropertyName("Maximum Fund Application Rate")]

        public string? MaximumFundApplicationRate { get; set; }
        [JsonPropertyName("Disburcement Share Of Loan")]

        public string? DisburcementShareOfLoan { get; set; }
        [JsonPropertyName("Disburcement Share Of Bond")]

        public string? DisburcementShareOfBond { get; set; }
        [JsonPropertyName("Incremental IFB Deposit Share ")]

        public string? IncrementalIfbDepositShare { get; set; }
        [JsonPropertyName("Incremental Conventional Deposit Share")]

        public string? IncrementalConventionalDepositShare { get; set; }
        [JsonPropertyName("Incremental Conventional Saving Deposit Share")]

        public string? IncrementalConventionalSavingDepositShare { get; set; }
        [JsonPropertyName("Incremental Conventional Time Deposit Share")]

        public string? IncrementalConventionalTimeDepositShare { get; set; }
        [JsonPropertyName("Effective Interest Rate Of Loan")]

        public string? EffectiveInterestRateOfLoan { get; set; }
        [JsonPropertyName("Effective Interest Rate Of Bond")]

        public string? EffectiveInterestRateOfBond { get; set; }

        [JsonPropertyName("Deposit Interest Rate For Saving")]

        public string? DepositInterestRateForSaving { get; set; }
        [JsonPropertyName("Deposit Interest Rate For Time")]

        public string? DepositInterestRateForTime { get; set; }








        //public int? SeverityCatId { get; set; }
        //public string? Year { get; set; }
        //public string? Quarter { get; set; }

        //public string? NplGrowth { get; set; }

        //public string? NplShare { get; set; }

        //public string? InterestRateForLongTermLAndA { get; set; }

        //public string? DepositGrowthPerDrawdown { get; set; }

        //public string? UnplannedMaterializationOfCommitmentsAdjusted { get; set; }

        //public string? TotalNetCurrentLiability { get; set; }

        //public string? Top10DepositorsShareFromTotalDeposit { get; set; }

        //public string? Top100DepositorsShareFromTotalDeposit { get; set; }

        //public string? Top1000DepositorsShareFromTotalDeposit { get; set; }

        //public string? Top10DepositorsWithdraw { get; set; }

        //public string? Top100DepositorsWithdraw { get; set; }

        //public string? Top1000DepositorsWithdraw { get; set; }

        //public string? DepositMaturingInTheNextThreeMonths { get; set; }

        //public string? ScheduledPayables { get; set; }

        //public string? InterestRateIncrease { get; set; }

        //public string? InterestRateDecrease { get; set; }

        //public string? TheShareOfFcyBsByCuurenyTypeUsd { get; set; }

        //public string? DevaluationOfBirrToUsdShareOfTheGapBnOfficialAndParallel { get; set; }

        //public string? MidRateGrowthUsdToBirr { get; set; }

        //public string? TheIncrementOnTheActualMidRateImpactedByTheAverageGrowthRateAndDevaluation { get; set; }

        //public string? CreditConversionFactorForLc { get; set; }

        //public string? CreditConversionFactorForGuarantee { get; set; }

        //public string? ActualLossPerNearMissLossToAverageOfTheThreeYearsGrossIncomeRatio { get; set; }

        //public string? External { get; set; }

        //public string? People { get; set; }

        //public string? Process { get; set; }

        //public string? System { get; set; }

        //public string? PrincipalCollectionFromTotalCollection { get; set; }

        //public string? InterestCollectionFromTotalCollection { get; set; }

        //public string? PrincipalCollectionShareOfBond { get; set; }

        //public string? PrincipalCollectionShareOfLoanAndAdvance { get; set; }

        //public string? ShareOfNewLoanDisbursmentFromTheTotalDisbursment { get; set; }

        //public string? ShareOfFreshBondDisbursmentFromTheTotalDisbursment { get; set; }

        //public string? RatioOfPrincipalLoanCollectionToPrincipalLoansAndAdvancesAmount { get; set; }

        //public string? ShareOfPrincipalBondCollectionToPrincipalBondAmount { get; set; }

        //public string? ShareOfNcsbcFromTheTotalLoan { get; set; }

        //public string? LegalReserve { get; set; }

        //public string? IncrementalDepositNetOfNonFundImpact { get; set; }

        //public string? MaximumFundApplicationRate { get; set; }

        //public string? DisburcementShareOfLoan { get; set; }

        //public string? DisburcementShareOfBond { get; set; }

        //public string? IncrementalIfbDepositShare { get; set; }

        //public string? IncrementalConventionalDepositShare { get; set; }

        //public string? IncrementalConventionalSavingDepositShare { get; set; }

        //public string? IncrementalConventionalTimeDepositShare { get; set; }

        //public string? EffectiveInterestRateOfLoan { get; set; }

        //public string? EffectiveInterestRateOfBond { get; set; }

        //public string? DepositInterestRateForSaving { get; set; }

        //public string? DepositInterestRateForTime { get; set; }

        public DateTime? UploadedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UploaderUserId { get; set; }

        public int? UpdaterUserId { get; set; }

        public int? Status { get; set; }
    }
}
