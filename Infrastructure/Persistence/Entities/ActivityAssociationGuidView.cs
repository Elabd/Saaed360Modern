using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityAssociationGuidView
{
    public Guid ActivityAssociationGuid { get; set; }

    public string ActivityAssociationDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid RelatedActivityGuid { get; set; }

    public string? ActivityRelationshipTypeCode { get; set; }

    public string? ActivityRelationShipCategoryCode { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
