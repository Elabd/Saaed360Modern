using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentPerson
{
    public long Id { get; set; }

    public long IncidentId { get; set; }

    public long? IncidentVehicleId { get; set; }

    public string DriverName { get; set; } = null!;

    public string? NationalIdImg { get; set; }

    public string? NationalId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public int? NationalityId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModificationBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? Notes { get; set; }

    public long? TempId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<EventIncidentImage> EventIncidentImages { get; set; } = new List<EventIncidentImage>();

    public virtual EventIncident Incident { get; set; } = null!;

    public virtual EventIncidentVehicle? IncidentVehicle { get; set; }

    public virtual Person? ModificationByNavigation { get; set; }

    public virtual NationalityDim? Nationality { get; set; }
}
