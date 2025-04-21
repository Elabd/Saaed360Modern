using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncident
{
    public long Id { get; set; }

    public long EventId { get; set; }

    public long? IncidentTypeId { get; set; }

    public long? CriticalityLevelId { get; set; }

    public long? IncidentLocationId { get; set; }

    public DateTime? IncidentStartTime { get; set; }

    public DateTime? IncidentEndTime { get; set; }

    public int? StatusId { get; set; }

    public string? Notes { get; set; }

    public long? PersonId { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModificationBy { get; set; }

    public long? MissionId { get; set; }

    public bool? IsFinished { get; set; }

    public long? IncidentSubTypeId { get; set; }

    public bool? IsDeleted { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual EventIncidentCriticalityLevelDim? CriticalityLevel { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual ICollection<EventIncidentAction> EventIncidentActions { get; set; } = new List<EventIncidentAction>();

    public virtual ICollection<EventIncidentComment> EventIncidentComments { get; set; } = new List<EventIncidentComment>();

    public virtual ICollection<EventIncidentImage> EventIncidentImages { get; set; } = new List<EventIncidentImage>();

    public virtual ICollection<EventIncidentPerson> EventIncidentPeople { get; set; } = new List<EventIncidentPerson>();

    public virtual ICollection<EventIncidentsStatusLog> EventIncidentsStatusLogs { get; set; } = new List<EventIncidentsStatusLog>();

    public virtual EventsArea? IncidentLocation { get; set; }

    public virtual EventIncidentSubTypeDim? IncidentSubType { get; set; }

    public virtual EventIncidentTypeDim? IncidentType { get; set; }

    public virtual EventsMission? Mission { get; set; }

    public virtual Person? ModificationByNavigation { get; set; }

    public virtual Person? Person { get; set; }

    public virtual EventIncidentStatusDim? Status { get; set; }
}
