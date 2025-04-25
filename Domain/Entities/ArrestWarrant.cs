using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArrestWarrant
{
    public long ArrestWarrantId { get; set; }

    public Guid ArrestWarrantGuid { get; set; }

    public string ArrestWarrantDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
