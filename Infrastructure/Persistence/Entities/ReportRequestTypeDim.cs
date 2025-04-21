using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportRequestTypeDim
{
    public int ReportRequestTypeId { get; set; }

    public string? Description { get; set; }

    public string Code { get; set; } = null!;

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Url { get; set; }

    public string? ImageIcon { get; set; }

    public string? CultureDescriptionXml { get; set; }

    public virtual ICollection<ApprovalCycle> ApprovalCycles { get; set; } = new List<ApprovalCycle>();

    public virtual ICollection<ReportRequest> ReportRequests { get; set; } = new List<ReportRequest>();
}
