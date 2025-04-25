using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SearchDetail
{
    public long SearchDetailId { get; set; }

    public Guid SearchDetailGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int ParameterId { get; set; }

    public int DataTypeId { get; set; }

    public int CompareId { get; set; }

    public string? ParameterValue { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual SearchCompareDim Compare { get; set; } = null!;

    public virtual SearchDataTypeDim DataType { get; set; } = null!;

    public virtual SearchParameterDim Parameter { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
