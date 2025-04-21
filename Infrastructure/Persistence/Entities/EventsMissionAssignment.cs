using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsMissionAssignment
{
    public long MissionAssignId { get; set; }

    public long? PersonId { get; set; }

    public long? EventAreaId { get; set; }

    public string? Notes { get; set; }

    public long? MissionId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool? IsDeteted { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public int? MissionAssignmentStatusId { get; set; }

    public long? EventPersonId { get; set; }

    public long? ModifiedBy { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventsArea? EventArea { get; set; }

    public virtual ICollection<EventMissionAssignmentLog> EventMissionAssignmentLogs { get; set; } = new List<EventMissionAssignmentLog>();

    public virtual EventsPerson? EventPerson { get; set; }

    public virtual ICollection<EventsMissionAssignmentNotification> EventsMissionAssignmentNotifications { get; set; } = new List<EventsMissionAssignmentNotification>();

    public virtual EventsMission? Mission { get; set; }

    public virtual EventMissionAssignmentStatusDim? MissionAssignmentStatus { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Person? Person { get; set; }
}
