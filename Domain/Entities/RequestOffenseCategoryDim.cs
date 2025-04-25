using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestOffenseCategoryDim
{
    public int RequestOffenseCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<RequestOffense> RequestOffenses { get; set; } = new List<RequestOffense>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
