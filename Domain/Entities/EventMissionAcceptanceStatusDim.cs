using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventMissionAcceptanceStatusDim
{
    public int EventMissionAcceptanceStatusId { get; set; }

    public string ArabicDescription { get; set; } = null!;

    public string EnglishDescription { get; set; } = null!;

    public virtual ICollection<EventsMission> EventsMissions { get; set; } = new List<EventsMission>();
}
