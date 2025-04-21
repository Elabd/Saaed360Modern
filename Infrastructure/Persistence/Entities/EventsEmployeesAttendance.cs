using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsEmployeesAttendance
{
    public long EventsEmployeesAttandaceId { get; set; }

    public long? EventId { get; set; }

    public long? EventPatrolId { get; set; }

    public DateTime? FirstCheckinDate { get; set; }

    public DateTime? LastCheckoutDate { get; set; }

    public long? AttandaceTypeId { get; set; }

    public long? EmployeeId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? CurrentStatusId { get; set; }

    public string? LocationFirstCheckIn { get; set; }

    public long? MissionId { get; set; }

    public virtual EventsAttendanceTypeDim? AttandaceType { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventsAttendanceLogStatusDim? CurrentStatus { get; set; }

    public virtual Person? Employee { get; set; }

    public virtual Event? Event { get; set; }

    public virtual EventsPatrol? EventPatrol { get; set; }

    public virtual ICollection<EventsEmployeesAttendanceLog> EventsEmployeesAttendanceLogs { get; set; } = new List<EventsEmployeesAttendanceLog>();
}
