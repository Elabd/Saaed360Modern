using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ServiceCall
{
    public long ActivityId { get; set; }

    public int? ServiceCallCategoryId { get; set; }

    public int? ServiceCallSourceId { get; set; }

    public int? ServiceCallPriorityId { get; set; }

    public DateTime? ServiceCallArrivedDate { get; set; }

    public DateTime? ServiceCallDispatchedDate { get; set; }

    public DateTime? ServiceCallClearedDate { get; set; }

    public DateTime? ServiceCallReceivedDate { get; set; }

    public DateTime? ServiceCallStagedDate { get; set; }

    public DateTime? ServiceCallInControlDate { get; set; }

    public DateTime? ServiceCallEnrouteDate { get; set; }

    public bool? HazardCallIndicator { get; set; }

    public bool? IsSelfInitiated { get; set; }

    public bool? HasPriorsIndicator { get; set; }

    public bool? OutofServiceIndicator { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public int? ServiceCallIncidentTypeId { get; set; }

    public long? IcccdispatcherId { get; set; }

    public int? CustomerNotAnswerReasonId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ServiceCallCategoryDim? ServiceCallCategory { get; set; }

    public virtual ServiceCallIncidentTypeDim? ServiceCallIncidentType { get; set; }

    public virtual ServiceCallPriorityDim? ServiceCallPriority { get; set; }

    public virtual ServiceCallSourceDim? ServiceCallSource { get; set; }
}

