using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Event
{
    public long EventId { get; set; }

    public string EventNumber { get; set; } = null!;

    public string? EventName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? EventSourceId { get; set; }

    public string? Notes { get; set; }

    public int? CurrentStatusId { get; set; }

    public long? EmirateId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool? IsDeteted { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public int? PatrolsNumber { get; set; }

    public string? OrganizerName { get; set; }

    public string? OrganizerPhone { get; set; }

    public string? EventPolygon { get; set; }

    public string? CancellationReason { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventsStatusDim? CurrentStatus { get; set; }

    public virtual EmirateDim? Emirate { get; set; }

    public virtual ICollection<EventIncident> EventIncidents { get; set; } = new List<EventIncident>();

    public virtual EventsSourceDim? EventSource { get; set; }

    public virtual ICollection<EventsArea> EventsAreas { get; set; } = new List<EventsArea>();

    public virtual ICollection<EventsEmployeesAttendance> EventsEmployeesAttendances { get; set; } = new List<EventsEmployeesAttendance>();

    public virtual ICollection<EventsMission> EventsMissions { get; set; } = new List<EventsMission>();

    public virtual ICollection<EventsPerson> EventsPeople { get; set; } = new List<EventsPerson>();

    public virtual ICollection<EventsStatusLog> EventsStatusLogs { get; set; } = new List<EventsStatusLog>();

    public virtual ICollection<EventsSupervisor> EventsSupervisors { get; set; } = new List<EventsSupervisor>();

    public virtual ICollection<PersonHistoricalTokenShared> PersonHistoricalTokenShareds { get; set; } = new List<PersonHistoricalTokenShared>();
}
