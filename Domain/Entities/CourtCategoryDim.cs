using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtCategoryDim
{
    public int CourtCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Court> Courts { get; set; } = new List<Court>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
