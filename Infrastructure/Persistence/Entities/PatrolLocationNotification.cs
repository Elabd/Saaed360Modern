using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PatrolLocationNotification
{
    public long PatrolLocationNotificationId { get; set; }

    public string? Name { get; set; }

    public string? DeviceCode { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public DateTime? LocationDate { get; set; }

    public int? Speed { get; set; }

    public decimal? BatteryVoltage { get; set; }

    public decimal? BatteryCurrent { get; set; }

    public string? Code { get; set; }

    public bool? IsNotified { get; set; }

    public string? GroupIdentifier { get; set; }

    public DateTime? NotificationTime { get; set; }

    public long? PatrolId { get; set; }

    public string? TrackerCode { get; set; }
}
