using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentVehicle
{
    public long Id { get; set; }

    public long IncidentId { get; set; }

    public int VehicleTypeId { get; set; }

    public int? PlateSourceId { get; set; }

    public int? PlateCategoryId { get; set; }

    public int? PlateColourId { get; set; }

    public string? PlateNumber { get; set; }

    public int? VehicleColourId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModificationBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? PlateKindId { get; set; }

    public string? PlateImg { get; set; }

    public string? Notes { get; set; }

    public long? TempId { get; set; }

    public virtual ICollection<EventIncidentImage> EventIncidentImages { get; set; } = new List<EventIncidentImage>();

    public virtual ICollection<EventIncidentPerson> EventIncidentPeople { get; set; } = new List<EventIncidentPerson>();
}
