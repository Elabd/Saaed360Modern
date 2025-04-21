using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActionTakenDim
{
    public int ActionTakenId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Desc { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ReportActionTaken> ReportActionTakens { get; set; } = new List<ReportActionTaken>();
}
