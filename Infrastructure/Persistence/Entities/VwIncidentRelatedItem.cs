using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VwIncidentRelatedItem
{
    public long? ParentId { get; set; }

    public long ActivityItemId { get; set; }

    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public string? SerialIdentification { get; set; }

    public long OrganizationId { get; set; }

    public string? CodeNumber { get; set; }

    public string? ActivityItemStatusCode { get; set; }

    public string? ActivityItemStatus { get; set; }

    public string? OrganizationName { get; set; }

    public string? OrganizationCategory { get; set; }

    public string? OrganizationCategoryCode { get; set; }

    public Guid? WorkFlowGuid { get; set; }

    public string? ActivityCategoryCode { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public string? FirstName { get; set; }

    public int? PersonCategoryId { get; set; }
}
