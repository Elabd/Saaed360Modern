using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallPriorityDim
{
    public int ServiceCallPriorityId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Color { get; set; }

    public string? Name { get; set; }

    public int? TfmId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<ServiceCallPriorityReasonDim> ServiceCallPriorityReasonDims { get; set; } = new List<ServiceCallPriorityReasonDim>();

    public virtual ICollection<ServiceCall> ServiceCalls { get; set; } = new List<ServiceCall>();
}

