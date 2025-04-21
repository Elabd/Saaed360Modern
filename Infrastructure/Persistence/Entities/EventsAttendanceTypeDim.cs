using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsAttendanceTypeDim
{
    public long AttandaceTypId { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<EventsAttendanceLogStatusDim> EventsAttendanceLogStatusDims { get; set; } = new List<EventsAttendanceLogStatusDim>();

    public virtual ICollection<EventsEmployeesAttendance> EventsEmployeesAttendances { get; set; } = new List<EventsEmployeesAttendance>();
}
