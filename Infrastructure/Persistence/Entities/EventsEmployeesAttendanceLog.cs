using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsEmployeesAttendanceLog
{
    public long EventAttendanceLogId { get; set; }

    public long? EventAttendanceId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? CreatedBy { get; set; }

    public int? EventAttendanceLogStatusId { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public long? ModifiedBy { get; set; }

    public virtual EventsEmployeesAttendance? EventAttendance { get; set; }

    public virtual EventsAttendanceLogStatusDim? EventAttendanceLogStatus { get; set; }
}
