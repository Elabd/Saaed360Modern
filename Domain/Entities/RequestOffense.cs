using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestOffense
{
    public long RequestOffenseId { get; set; }

    public Guid RequestOffenseGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int? OffenseCodeId { get; set; }

    public int? RequestOffenseCategoryId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual OffenseCodeDim? OffenseCode { get; set; }

    public virtual RequestOffenseCategoryDim? RequestOffenseCategory { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
