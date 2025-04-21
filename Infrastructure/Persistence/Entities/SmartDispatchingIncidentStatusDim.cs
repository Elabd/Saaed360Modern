using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SmartDispatchingIncidentStatusDim
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<IcccincidentLog> IcccincidentLogNewStatusNavigations { get; set; } = new List<IcccincidentLog>();

    public virtual ICollection<IcccincidentLog> IcccincidentLogOldStatusNavigations { get; set; } = new List<IcccincidentLog>();

    public virtual ICollection<IcccincidentRequest> IcccincidentRequests { get; set; } = new List<IcccincidentRequest>();

    public virtual ICollection<SmartDispatchingIncidentStatusLog> SmartDispatchingIncidentStatusLogNewStatusNavigations { get; set; } = new List<SmartDispatchingIncidentStatusLog>();

    public virtual ICollection<SmartDispatchingIncidentStatusLog> SmartDispatchingIncidentStatusLogOldStatusNavigations { get; set; } = new List<SmartDispatchingIncidentStatusLog>();
}
