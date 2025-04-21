using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtEventCategoryDim
{
    public int CourtEventCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<CourtEvent> CourtEvents { get; set; } = new List<CourtEvent>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
