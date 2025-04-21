using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AreaCategoryDim
{
    public int AreaCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
