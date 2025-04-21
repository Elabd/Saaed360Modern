using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestViolationCategoryDim
{
    public int RequestViolationCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<RequestViolation> RequestViolations { get; set; } = new List<RequestViolation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
