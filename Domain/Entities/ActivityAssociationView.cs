using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityAssociationView
{
    public long ActivityAssociationId { get; set; }

    public string ActivityAssociationDescription { get; set; } = null!;

    public long RelatedActivityId { get; set; }

    public long ActivityId { get; set; }

    public string? ActivityRelationshipTypeCode { get; set; }

    public string? ActivityRelationshipTypeDescription { get; set; }

    public string? ActivityRelationShipCategoryCode { get; set; }

    public string? ActivityRelationShipCategoryDescription { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
