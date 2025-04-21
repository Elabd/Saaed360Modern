using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReasonCategoryDim
{
    public int ReasonCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsReport { get; set; }

    public virtual ICollection<ActivityReasonDim> ActivityReasonDims { get; set; } = new List<ActivityReasonDim>();
}
