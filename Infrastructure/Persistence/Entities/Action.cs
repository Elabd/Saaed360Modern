using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Action
{
    public Guid Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string Source { get; set; } = null!;

    public string ActionName { get; set; } = null!;

    public string? Username { get; set; }

    public string Ipaddress { get; set; } = null!;

    public int DeviceTypeId { get; set; }

    public string? FailureReason { get; set; }

    public int ReferenceTypeId { get; set; }

    public string? Reference { get; set; }

    public bool IsFailure { get; set; }

    public virtual DeviceType DeviceType { get; set; } = null!;

    public virtual ReferenceType ReferenceType { get; set; } = null!;
}
