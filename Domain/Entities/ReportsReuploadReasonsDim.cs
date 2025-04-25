using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportsReuploadReasonsDim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ReportsReuploadLog> ReportsReuploadLogs { get; set; } = new List<ReportsReuploadLog>();
}
