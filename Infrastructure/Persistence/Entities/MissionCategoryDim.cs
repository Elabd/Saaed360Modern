using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MissionCategoryDim
{
    public int MissionCategoryId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<EventsMission> EventsMissions { get; set; } = new List<EventsMission>();
}
