using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Status
{
    public int StatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public int? RowStatusId { get; set; }

    public int? EnitytId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Entity? Enityt { get; set; }

    public virtual ICollection<IncidentCategoryStatus> IncidentCategoryStatuses { get; set; } = new List<IncidentCategoryStatus>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
