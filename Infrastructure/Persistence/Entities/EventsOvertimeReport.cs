using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsOvertimeReport
{
    public long Id { get; set; }

    public int EventsOvertimeReportConfigurationsId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime OvertimeDate { get; set; }

    public long EventId { get; set; }

    public string EventName { get; set; } = null!;

    public long PersonId { get; set; }

    public string PersonName { get; set; } = null!;

    public string PersonUserName { get; set; } = null!;

    public int JobTypeId { get; set; }

    public string JobType { get; set; } = null!;

    public bool IsPrivateVhicleUsed { get; set; }

    public decimal VehicleAllowance { get; set; }

    public decimal AttendanceInMinutes { get; set; }

    public decimal AttendanceInHours { get; set; }

    public decimal OvertimeAllowance { get; set; }

    public decimal TotalAllowance { get; set; }

    public string? Notes { get; set; }

    public bool IsDeleted { get; set; }

    public virtual EventsOvertimeReportConfiguration EventsOvertimeReportConfigurations { get; set; } = null!;
}
