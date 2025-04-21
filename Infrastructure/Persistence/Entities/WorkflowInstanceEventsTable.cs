using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class WorkflowInstanceEventsTable
{
    public int Id { get; set; }

    public Guid WorkflowInstanceId { get; set; }

    public string? WorkflowActivityDefinition { get; set; }

    public long RecordNumber { get; set; }

    public string? State { get; set; }

    public byte? TraceLevelId { get; set; }

    public string? Reason { get; set; }

    public string? ExceptionDetails { get; set; }

    public string? SerializedAnnotations { get; set; }

    public DateTime TimeCreated { get; set; }
}
