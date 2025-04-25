using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestCategoryDim
{
    public int RequestCategoryId { get; set; }

    public string? Description { get; set; }

    public string Code { get; set; } = null!;

    public string? CategorySubDescription { get; set; }

    public string? CategorySubCode { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
