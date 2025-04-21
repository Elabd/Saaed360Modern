using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccincidentRequest
{
    public long Id { get; set; }

    public int RequestStatus { get; set; }

    public string IcccincidentNumber { get; set; } = null!;

    public long IcccincidentRequestInfoId { get; set; }

    public bool IsValid { get; set; }

    public DateTime RequestDateTime { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public long? SaaedAreaId { get; set; }

    public long? ReceivedBy { get; set; }

    public long IcccincidentId { get; set; }

    public long? SaaedIncidentId { get; set; }

    public long? ControlCenterId { get; set; }

    public int Icccservice { get; set; }

    public byte[] TimeStamp { get; set; } = null!;

    public DateTime? ReceivedTime { get; set; }

    public int? SmartDispatchingStatusId { get; set; }

    public virtual ICollection<IcccincidentLog> IcccincidentLogs { get; set; } = new List<IcccincidentLog>();

    public virtual ICollection<IcccincidentRequestDetail> IcccincidentRequestDetails { get; set; } = new List<IcccincidentRequestDetail>();

    public virtual IcccincidentRequestInfo IcccincidentRequestInfo { get; set; } = null!;

    public virtual ICollection<IcccrequestComment> IcccrequestComments { get; set; } = new List<IcccrequestComment>();

    public virtual ICollection<IcccrequestDispatcher> IcccrequestDispatchers { get; set; } = new List<IcccrequestDispatcher>();

    public virtual Person? ReceivedByNavigation { get; set; }

    public virtual IcccrequestStatus RequestStatusNavigation { get; set; } = null!;

    public virtual Activity? SaaedIncident { get; set; }

    public virtual ICollection<SmartDispatchingIncidentStatusLog> SmartDispatchingIncidentStatusLogs { get; set; } = new List<SmartDispatchingIncidentStatusLog>();

    public virtual ICollection<SmartDispatchingReturnToOperationRoomLog> SmartDispatchingReturnToOperationRoomLogs { get; set; } = new List<SmartDispatchingReturnToOperationRoomLog>();

    public virtual SmartDispatchingIncidentStatusDim? SmartDispatchingStatus { get; set; }
}
