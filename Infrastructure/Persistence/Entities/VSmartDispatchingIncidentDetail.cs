using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VSmartDispatchingIncidentDetail
{
    public long Id { get; set; }

    public long IcccincidentId { get; set; }

    public string IcccincidentNumber { get; set; } = null!;

    public DateTime RequestTime { get; set; }

    public DateTime? DispatchTime { get; set; }

    public DateTime? ConfirmationTime { get; set; }

    public decimal? ExpectedTime { get; set; }

    public long? PatrolId { get; set; }

    public long? PersonId { get; set; }

    public long? ControlCenterId { get; set; }

    public int IncidentPriorityId { get; set; }

    public int IcccrequestStatusId { get; set; }

    public string IcccrequestStatusCode { get; set; } = null!;

    public string IcccrequestStatus { get; set; } = null!;

    public int StatusId { get; set; }

    public string StatusCode { get; set; } = null!;

    public string? Status { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public long? EmirateId { get; set; }

    public string? EmirateName { get; set; }

    public long AreaId { get; set; }

    public string? AreaName { get; set; }

    public int SourceOperationRoomId { get; set; }

    public string Address { get; set; } = null!;

    public string CallerName { get; set; } = null!;

    public string CallerPhone { get; set; } = null!;

    public string? Description { get; set; }
}
