using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RacreditCbenoor
{
    public int Id { get; set; }

    public string AccYear { get; set; } = null!;

    public string AccQuarter { get; set; } = null!;

    public string? CreditTop10CbeNoorPrincipalOutstandingBalance { get; set; }

    public string? CreditTop20CbeNoorPrincipalOutstandingBalance { get; set; }

    public string? CreditTop50CbeNoorPrincipalOutstandingBalance { get; set; }

    public string? CreditDtsPrincipalOutstandingBalanceCbeNoor { get; set; }

    public string? CreditIntTradePrincipalOutstandingBalanceCbeNoor { get; set; }

    public string? CreditAgriculturePrincipalOutstandingBalanceCbeNoor { get; set; }

    public string? CreditBuildingConPrincipalOutstandingBalanceCbeNoor { get; set; }

    public string? CreditIndustryPrincipalOutstandingBalanceCbeNoor { get; set; }

    public string? CreditConsumerLoanPrincipalOutstandingBalanceCbeNoor { get; set; }

    public string? CreditHeadOfficeCbeNoorFinancingPrincipalOutstandingBalance { get; set; }

    public string? CreditCentralRegionCbeNoorFinancingPrincipalOutstandingBalance { get; set; }

    public string? CreditNorthEastRegionCbeNoorFinancingPrincipalOutstandingBalance { get; set; }

    public string? CreditSouthWestRegionCbeNoorFinancingPrincipalOutstandingBalance { get; set; }

    public string? CreditMurabahaFinancingsPrincipalOutstandingBalance { get; set; }

    public string? CreditQerdFinancingsPrincipalOutstandingBalance { get; set; }

    public string? CreditLongTermFinancingsPrincipalOutstandingBalance { get; set; }

    public string? CreditMediumTermFinancingsPrincipalOutstandingBalance { get; set; }

    public string? CreditShortTermFinancingsPrincipalOutstandingBalance { get; set; }

    public string? CreditRetailFinancingsPrincipalOutstandingBalance { get; set; }

    public string? CreditWholesaleFinancingsPrincipalOutstandingBalance { get; set; }

    public string? CreditNpfsPrincipalOutstandingBalance { get; set; }

    public string? CreditZeroDaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? Credit18DaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? Credit829DaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? CreditSpecialMentionPrincipalOutstandingBalance { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public int? Statuses { get; set; }

    public string? Descriptions { get; set; }

    public string? History { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
