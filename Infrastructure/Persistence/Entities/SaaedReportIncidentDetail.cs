using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedReportIncidentDetail
{
    public long IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentCreationDate { get; set; }

    public string? Area { get; set; }

    public string? Priority { get; set; }

    public string? IncidentType { get; set; }

    public string? IncidentCategory { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public string CallReceiver { get; set; } = null!;

    public string CallDispatcher { get; set; } = null!;

    public string? PatrolCode { get; set; }

    public DateTime? CallReceivedOn { get; set; }

    public TimeOnly? SavingResponseTime { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public DateTime? DispatchDateTime { get; set; }

    public TimeOnly? DispatchResponseTime { get; set; }

    public DateTime? Arrival1 { get; set; }

    public TimeOnly? Arrival1ResponseTime { get; set; }

    public DateTime? Arrival2 { get; set; }

    public TimeOnly? Arrival2ResponseTime { get; set; }

    public DateTime? StartArc { get; set; }

    public TimeOnly? ReconstructionTime { get; set; }

    public TimeOnly? AverageResponseTime { get; set; }

    public TimeOnly? TotalResponseTime { get; set; }

    public DateTime? LocationIdentifiedDatetime { get; set; }

    public DateTime? AssignedDatetime { get; set; }

    public DateTime? AssignResourceDatetime { get; set; }

    public DateTime? OnRoutDateTime { get; set; }

    public DateTime? AcknowledgeDatetime { get; set; }

    public DateTime? AtSceneDatetime { get; set; }

    public DateTime? LeftSceneDatetime { get; set; }

    public DateTime? ClosingDatetime { get; set; }

    public string? Notes { get; set; }

    public string? Dispatchers { get; set; }

    public DateTime? EndArc { get; set; }

    public long? SourceId { get; set; }
}
