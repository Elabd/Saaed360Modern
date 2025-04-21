using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsOvertimeReportConfiguration
{
    public int Id { get; set; }

    public decimal VehicleAllowanceAmount { get; set; }

    public decimal OvertimeAllowancePerHour { get; set; }

    public decimal DailyAllowanceForCalledPerson { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<EventsOvertimeReport> EventsOvertimeReports { get; set; } = new List<EventsOvertimeReport>();
}
