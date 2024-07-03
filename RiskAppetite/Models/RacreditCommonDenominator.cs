using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RacreditCommonDenominator
{
    public int Id { get; set; }

    public string AccYear { get; set; } = null!;

    public string AccQuarter { get; set; } = null!;

    public string? CreditTotalLoansAndAdvancesPrincipalOutstandingBalance { get; set; }

    public string? CreditTotalCapital { get; set; }

    public string? CreditTotalPrivateLoansAndAdvancesPrincipalOutstandingBalance { get; set; }

    public string? CreditTotalWholesaleLoansAndAdvancesPrincipalOutstandingBalance { get; set; }

    public string? CreditTotalRetailLoansAndAdvancesPrincipalOutstandingBalance { get; set; }

    public string? CreditTotalCbeNoorPrincipalOutstandingBalanceWithMarkup { get; set; }

    public string? CreditTotalCentralRegionPrincipalOutstandingBalance { get; set; }

    public string? CreditTotalNorthEastRegionPrincipalOutstandingBalance { get; set; }

    public string? CreditTotalSouthWestRegionPrincipalOutstandingBalance { get; set; }

    public string? CreditTotalNplsPrincipalOutstandingBalanceOfTheBank { get; set; }

    public string? CreditTotalNpfsPrincipalOutstandingBalanceOfCbeNoor { get; set; }

    public string? CreditTotalNplsPrincipalOutstandingBalanceOfWholesaleBusiness { get; set; }

    public string? CreditTotalNplsPrincipalOutstandingBalanceOfRetailBusiness { get; set; }

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
