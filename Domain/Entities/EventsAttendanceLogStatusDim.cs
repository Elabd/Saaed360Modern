using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsAttendanceLogStatusDim
{
    public int EventAttandaceLogStatusId { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public string? NavigatePath { get; set; }

    public int? OrderNumber { get; set; }

    public long? EventAttandaceTypeId { get; set; }

    public virtual EventsAttendanceTypeDim? EventAttandaceType { get; set; }

    public virtual ICollection<EventsEmployeesAttendanceLog> EventsEmployeesAttendanceLogs { get; set; } = new List<EventsEmployeesAttendanceLog>();

    public virtual ICollection<EventsEmployeesAttendance> EventsEmployeesAttendances { get; set; } = new List<EventsEmployeesAttendance>();
}
