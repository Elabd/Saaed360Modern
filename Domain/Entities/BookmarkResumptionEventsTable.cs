using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BookmarkResumptionEventsTable
{
    public int Id { get; set; }

    public Guid WorkflowInstanceId { get; set; }

    public long? RecordNumber { get; set; }

    public byte? TraceLevelId { get; set; }

    public string? BookmarkName { get; set; }

    public Guid? BookmarkScope { get; set; }

    public string? OwnerActivityName { get; set; }

    public string? OwnerActivityId { get; set; }

    public string? OwnerActivityInstanceId { get; set; }

    public string? OwnerActivityType { get; set; }

    public string? SerializedAnnotations { get; set; }

    public DateTime TimeCreated { get; set; }
}
