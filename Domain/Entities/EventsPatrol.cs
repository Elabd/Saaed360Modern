using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsPatrol
{
    public long EventPatrolId { get; set; }

    public long? PatrolId { get; set; }

    public long? RecivedBy { get; set; }

    public DateTime? RecivedDatetime { get; set; }

    public DateTime? DelivaryDateTime { get; set; }

    public long? AreaId { get; set; }

    public long? SectorId { get; set; }

    public bool? IsDeliverd { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<EventsEmployeesAttendance> EventsEmployeesAttendances { get; set; } = new List<EventsEmployeesAttendance>();

    public virtual Item? Patrol { get; set; }

    public virtual Person? RecivedByNavigation { get; set; }

    public virtual Area? Sector { get; set; }
}
