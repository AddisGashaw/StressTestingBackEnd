using System;
using System.Collections.Generic;

namespace RiskAppetite.Models;

public partial class Credit
{
    public int Id { get; set; }

    public string? Param1 { get; set; }

    public string? Param2 { get; set; }

    public string? Param3 { get; set; }

    public int? UploaderUserId { get; set; }

    public int? ApproverUserId { get; set; }

    public int? Approvalstatus { get; set; }

    public DateTime? UploadedDate { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public virtual UserProfile? ApproverUser { get; set; }

    public virtual UserProfile? UploaderUser { get; set; }
}
