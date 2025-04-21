using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArrestCategoryDim
{
    public int ArrestCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Arrest> Arrests { get; set; } = new List<Arrest>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
