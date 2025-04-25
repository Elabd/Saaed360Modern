using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestCheckCategoryDim
{
    public int RequestCheckCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<RequestCheck> RequestChecks { get; set; } = new List<RequestCheck>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
