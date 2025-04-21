using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AreaAssociation
{
    public long AreaAssociationId { get; set; }

    public Guid AreaAssociationGuid { get; set; }

    public string AreaAssociationDescription { get; set; } = null!;

    public Guid AreaGuid { get; set; }

    public Guid RelatedAreaGuid { get; set; }

    public long RelatedAreaId { get; set; }

    public long AreaId { get; set; }

    public long SourceId { get; set; }

    public int? AreaRelationshipTypeId { get; set; }

    public int? AreaRelationShipCategoryId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public DateTime? FromDateTimeStamp { get; set; }

    public DateTime? ToDateTimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual AreaRelationshipCategoryDim? AreaRelationShipCategory { get; set; }

    public virtual AreaRelationshipTypeDim? AreaRelationshipType { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Area RelatedArea { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
