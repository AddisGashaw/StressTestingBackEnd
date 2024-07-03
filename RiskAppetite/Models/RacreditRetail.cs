using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class RacreditRetail
{
    public int Id { get; set; }

    public string AccYear { get; set; } = null!;

    public string AccQuarter { get; set; } = null!;

    public string? CreditTermLoansRetailPrincipalOutstandingBalance { get; set; }

    public string? CreditOverdraftRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditRevolvingRetailCreditsPrincipalOutstandingBalance { get; set; }

    public string? CreditLongTermRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditMediumTermRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditShortTermRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditHeadOfficeRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditCentralRegionRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditNorthEastRegionRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditSouthWestRegionRetailLoansPrincipalOutstandingBalance { get; set; }

    public string? CreditAffluentRetailCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditMiddleRetailCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditMassRetailCustomersPrincipalOutstandingBalance { get; set; }

    public string? CreditNplsRetailPrincipalOutstandingBalance { get; set; }

    public string? CreditZeroDaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? Credit18DaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? Credit829DaysArrearsPrincipalOutstandingBalance { get; set; }

    public string? CreditSpecialMentionOSBPrincipalOutstandingBalance { get; set; }

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
