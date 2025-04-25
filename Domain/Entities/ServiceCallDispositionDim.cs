using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallDispositionDim
{
    public int ServiceCallDispositionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}

