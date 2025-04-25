using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityAssociation
{
    public long ActivityAssociationId { get; set; }

    public Guid ActivityAssociationGuid { get; set; }

    public string ActivityAssociationDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid RelatedActivityGuid { get; set; }

    public long RelatedActivityId { get; set; }

    public long ActivityId { get; set; }

    public long SourceId { get; set; }

    public int? ActivityRelationshipTypeId { get; set; }

    public int? ActivityRelationShipCategoryId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ActivityRelationshipCategoryDim? ActivityRelationShipCategory { get; set; }

    public virtual ActivityRelationshipTypeDim? ActivityRelationshipType { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Activity RelatedActivity { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SourceDetail Source { get; set; } = null!;
}
