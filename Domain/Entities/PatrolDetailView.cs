using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PatrolDetailView
{
    public long ItemId { get; set; }

    public string? PatrolCode { get; set; }

    public string PlateNumber { get; set; } = null!;
}
