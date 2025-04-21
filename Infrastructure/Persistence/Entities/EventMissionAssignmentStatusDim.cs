using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventMissionAssignmentStatusDim
{
    public int MissionAssignmentStatusId { get; set; }

    public string? EnglishDescription { get; set; }

    public string? ArabicDescription { get; set; }

    public virtual ICollection<EventMissionAssignmentLog> EventMissionAssignmentLogs { get; set; } = new List<EventMissionAssignmentLog>();

    public virtual ICollection<EventsMissionAssignment> EventsMissionAssignments { get; set; } = new List<EventsMissionAssignment>();
}
