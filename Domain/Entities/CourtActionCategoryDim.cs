using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtActionCategoryDim
{
    public int CourtActionCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<CourtAction> CourtActions { get; set; } = new List<CourtAction>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
