using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationAssociation
{
    public long OrganizationAssociationId { get; set; }

    public Guid OrganizationAssociationGuid { get; set; }

    public string OrganizationAssociationDescription { get; set; } = null!;

    public long OrganizationRelatedId { get; set; }

    public Guid OrganizationRelatedGuid { get; set; }

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long SourceId { get; set; }

    public int? OrganizationAssociationCategoryId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual OrganizationAssociationCategoryDim? OrganizationAssociationCategory { get; set; }

    public virtual Organization OrganizationRelated { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
