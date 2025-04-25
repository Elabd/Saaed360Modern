using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsMissionTypeDim
{
    public int EventMissionTypeId { get; set; }

    public string Description { get; set; } = null!;

    public string? Endescription { get; set; }

    public virtual ICollection<EventsMissionsType> EventsMissionsTypes { get; set; } = new List<EventsMissionsType>();
}
