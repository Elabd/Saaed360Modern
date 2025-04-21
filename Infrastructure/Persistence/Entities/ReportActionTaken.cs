using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportActionTaken
{
    public long ReportActionTakenId { get; set; }

    public int? ActionTakenId { get; set; }

    public int? ReportId { get; set; }

    public string? Desc { get; set; }

    public DateTime? CreationDatetime { get; set; }

    public long? CreatedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ActionTakenDim? ActionTaken { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Report? Report { get; set; }
}
