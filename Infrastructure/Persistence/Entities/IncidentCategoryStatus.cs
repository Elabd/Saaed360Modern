using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentCategoryStatus
{
    public int IncidentCategoryStatusId { get; set; }

    public string? Code { get; set; }

    public int IncidentCategoryId { get; set; }

    public int StatusId { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual IncidentCategory IncidentCategory { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Status Status { get; set; } = null!;
}
