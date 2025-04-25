using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestService
{
    public long RequestServiceId { get; set; }

    public Guid RequestServiceGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int? RequestServiceCategoryId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RequestServiceCategoryDim? RequestServiceCategory { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}

