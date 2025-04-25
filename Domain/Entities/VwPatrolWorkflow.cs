using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VwPatrolWorkflow
{
    public int Id { get; set; }

    public Guid WorkflowInstanceId { get; set; }

    public long RecordNumber { get; set; }

    public string? State { get; set; }

    public byte? TraceLevelId { get; set; }

    public string ActivityRecordType { get; set; } = null!;

    public string? ActivityName { get; set; }

    public string? ActivityId { get; set; }

    public string? ActivityInstanceId { get; set; }

    public string? ActivityType { get; set; }

    public string? SerializedArguments { get; set; }

    public string? SerializedVariables { get; set; }

    public string? SerializedAnnotations { get; set; }

    public DateTime? TimeCreated { get; set; }
}
