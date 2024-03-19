using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class OprationalRisk
{
    public int Id { get; set; }

    public string? Year { get; set; }

    public string? Quarter { get; set; }

    public string? ActualIncidentsExternal { get; set; }

    public string? ActualIncidentsPeople { get; set; }

    public string? ActualIncidentsProcess { get; set; }

    public string? ActualIncidentsSystem { get; set; }

    public string? NearMissesExternal { get; set; }

    public string? NearMissesPeople { get; set; }

    public string? NearMissesProcess { get; set; }

    public string? NearMissesSystem { get; set; }

    public string? Revenue { get; set; }

    public string? NetInterestIncome { get; set; }

    public string? NetNonInterestIncome { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
