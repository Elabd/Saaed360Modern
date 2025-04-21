using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsPerson
{
    public long EventPersonId { get; set; }

    public long? PersonId { get; set; }

    public long? EventId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool? IsDeteted { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public int? EventsEmployeeTypeId { get; set; }

    public int? EventsPersonJobTypeId { get; set; }

    public bool? IsPrivateVehicleUsed { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Event? Event { get; set; }

    public virtual EventsEmployeeTypeDim? EventsEmployeeType { get; set; }

    public virtual ICollection<EventsMissionAssignment> EventsMissionAssignments { get; set; } = new List<EventsMissionAssignment>();

    public virtual EventsPersonJobTypeDim? EventsPersonJobType { get; set; }

    public virtual Person? Person { get; set; }
}
