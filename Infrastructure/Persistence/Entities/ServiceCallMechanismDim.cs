using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ServiceCallMechanismDim
{
    public int ServiceCallMechanismId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public bool? IsOutOfServiceType { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}

