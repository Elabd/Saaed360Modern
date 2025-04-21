using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsMissionStatusDim
{
    public int EventsMissionStatusId { get; set; }

    public string? Description { get; set; }

    public string? EnglishDescription { get; set; }

    public virtual ICollection<EventsMission> EventsMissions { get; set; } = new List<EventsMission>();

    public virtual ICollection<EventsMissionsStatusLog> EventsMissionsStatusLogs { get; set; } = new List<EventsMissionsStatusLog>();
}
