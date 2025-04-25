using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentCategory
{
    public int IncidentCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? Order { get; set; }

    public virtual ICollection<IncidentCategoryStatus> IncidentCategoryStatuses { get; set; } = new List<IncidentCategoryStatus>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
