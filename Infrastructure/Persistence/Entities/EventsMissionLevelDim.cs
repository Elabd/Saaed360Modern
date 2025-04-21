using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsMissionLevelDim
{
    public int EventMissionLevelId { get; set; }

    public string? Description { get; set; }

    public string? EnDescription { get; set; }

    public virtual ICollection<EventsMission> EventsMissions { get; set; } = new List<EventsMission>();
}
