using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewAttendedPatrolLocation
{
    public long AreaItemId { get; set; }

    public long ItemId { get; set; }

    public long? AreaId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime? LocationDate { get; set; }

    public string? SerialIdentification { get; set; }

    public string? DeviceCode { get; set; }

    public string? TrackerCode { get; set; }

    public string SectorCode { get; set; } = null!;

    public string PersonName { get; set; } = null!;

    public bool? IsAssigned { get; set; }
}
