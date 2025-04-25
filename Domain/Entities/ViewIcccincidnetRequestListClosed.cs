using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewIcccincidnetRequestListClosed
{
    public long Id { get; set; }

    public int RequestStatus { get; set; }

    public long? ControlCenterId { get; set; }

    public string IcccincidentNumber { get; set; } = null!;

    public DateTime RequestDateTime { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public bool IsValid { get; set; }

    public long? ReceivedBy { get; set; }

    public string? FirstName { get; set; }

    public long? SaaedAreaId { get; set; }

    public int Icccservice { get; set; }

    public long IcccincidentRequestInfoId { get; set; }

    public string Address { get; set; } = null!;

    public long Area { get; set; }

    public long Emirate { get; set; }

    public string CallerName { get; set; } = null!;

    public string CallerNumber { get; set; } = null!;

    public int IncidentPriorityId { get; set; }

    public string IncidentType { get; set; } = null!;

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int SourceOperationRoomId { get; set; }

    public long? DispatcherId { get; set; }

    public string? Comment { get; set; }

    public bool? IsAml { get; set; }
}
