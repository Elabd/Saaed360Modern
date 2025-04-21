using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccincidentRequestInfo
{
    public long IcccincidentRequestInfoId { get; set; }

    public int SourceOperationRoomId { get; set; }

    public string CallerNumber { get; set; } = null!;

    public string CallerName { get; set; } = null!;

    public long Emirate { get; set; }

    public long Area { get; set; }

    public string Address { get; set; } = null!;

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string IncidentType { get; set; } = null!;

    public int IncidentPriorityId { get; set; }

    public string? Description { get; set; }

    public bool? IsAml { get; set; }

    public bool? IsDetectLocation { get; set; }

    public virtual ICollection<IcccincidentRequest> IcccincidentRequests { get; set; } = new List<IcccincidentRequest>();
}
