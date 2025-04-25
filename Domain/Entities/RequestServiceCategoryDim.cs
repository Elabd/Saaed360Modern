using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestServiceCategoryDim
{
    public int RequestServiceCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<RequestService> RequestServices { get; set; } = new List<RequestService>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

