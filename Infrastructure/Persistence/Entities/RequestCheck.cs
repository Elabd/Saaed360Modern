using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestCheck
{
    public long RequestCheckId { get; set; }

    public Guid RequestCheckGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int? RequestCheckCategoryId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RequestCheckCategoryDim? RequestCheckCategory { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
