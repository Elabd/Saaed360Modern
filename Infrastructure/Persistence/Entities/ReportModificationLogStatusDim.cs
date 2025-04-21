using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportModificationLogStatusDim
{
    public int ReportModificationLogStatusId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string Desc { get; set; } = null!;

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ReportModificationLog> ReportModificationLogs { get; set; } = new List<ReportModificationLog>();
}
