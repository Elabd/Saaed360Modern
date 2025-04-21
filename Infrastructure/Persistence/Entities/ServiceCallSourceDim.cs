using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ServiceCallSourceDim
{
    public int ServiceCallSourceId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<ServiceCall> ServiceCalls { get; set; } = new List<ServiceCall>();
}

