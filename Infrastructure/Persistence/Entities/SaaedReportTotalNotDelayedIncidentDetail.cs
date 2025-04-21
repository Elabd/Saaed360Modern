using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedReportTotalNotDelayedIncidentDetail
{
    public long? IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentCreationDate { get; set; }

    public string? Area { get; set; }

    public string? Priority { get; set; }

    public string? PriorityColor { get; set; }

    public string? IncidentType { get; set; }

    public string? IncidentCategory { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public string? CallReceiver { get; set; }

    public long? CallReceiverId { get; set; }

    public string? CallReceiverCode { get; set; }

    public string? CallDispatcher { get; set; }

    public long? DispatcherId { get; set; }

    public string? DispatcherCode { get; set; }

    public string? PatrolCode { get; set; }

    public DateTime? CallReceivedOn { get; set; }

    public int? SavingResponseTime { get; set; }

    public int? DispatchResponseTime { get; set; }

    public int? Arrival1ResponseTime { get; set; }

    public int? Arrival2ResponseTime { get; set; }

    public int? ReconstructionTime { get; set; }

    public int? AverageResponseTime { get; set; }

    public int? TotalResponseTime { get; set; }

    public int? AverageAssignTime { get; set; }

    public int? AverageClosedTime { get; set; }

    public DateTime? RingingDateTime { get; set; }

    public DateTime? LocationIdentifiedDatetime { get; set; }

    public DateTime? SaveIncidentDatetime { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public DateTime? DispatchDateTime { get; set; }

    public DateTime? AssignResourceDatetime { get; set; }

    public DateTime? AtSceneDatetime { get; set; }

    public DateTime? LeftSceneDatetime { get; set; }

    public DateTime? ClosingDatetime { get; set; }

    public DateTime? AssignedDatetime { get; set; }

    public DateTime? AcknowledgeDatetime { get; set; }

    public DateTime? OnRoutDateTime { get; set; }

    public DateTime? Arrival1 { get; set; }

    public DateTime? Arrival2 { get; set; }

    public DateTime? StartArc { get; set; }

    public DateTime? EndArc { get; set; }

    public string? Notes { get; set; }

    public string? Dispatchers { get; set; }

    public long? SourceId { get; set; }

    public string? ControlCenter { get; set; }
}
