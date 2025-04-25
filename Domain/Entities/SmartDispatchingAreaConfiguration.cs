using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SmartDispatchingAreaConfiguration
{
    public int Id { get; set; }

    public long AreaId { get; set; }

    public int? RuralAreaTime { get; set; }

    public int? UrbanAreaTime { get; set; }

    public int? DesertAreaTime { get; set; }

    public bool IsEnabled { get; set; }

    public virtual Area Area { get; set; } = null!;
}
