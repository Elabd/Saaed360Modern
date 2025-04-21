using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DocketCategoryDim
{
    public int DocketCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Docket> Dockets { get; set; } = new List<Docket>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
