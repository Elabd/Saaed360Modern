using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CustomTrackingEventsTable
{
    public int Id { get; set; }

    public Guid WorkflowInstanceId { get; set; }

    public long? RecordNumber { get; set; }

    public byte? TraceLevelId { get; set; }

    public string? CustomRecordName { get; set; }

    public string? ActivityName { get; set; }

    public string? ActivityId { get; set; }

    public string? ActivityInstanceId { get; set; }

    public string? ActivityType { get; set; }

    public string? SerializedData { get; set; }

    public string? SerializedAnnotations { get; set; }

    public DateTime TimeCreated { get; set; }
}
