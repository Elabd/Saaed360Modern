using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccincidentItem
{
    public long ParentId { get; set; }

    public long ActivityItemId { get; set; }

    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public string? SerialIdentification { get; set; }

    public long OrganizationId { get; set; }

    public string? CodeNumber { get; set; }

    public string? ActivityItemStatusCode { get; set; }

    public string? ActivityItemStatus { get; set; }

    public string? DispatcherName { get; set; }

    public string? OrganizationCategory { get; set; }

    public string? OrganizationCategoryCode { get; set; }

    public Guid? WorkflowGuid { get; set; }

    public string? ActivityCategoryCode { get; set; }
}
