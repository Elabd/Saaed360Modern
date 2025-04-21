using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportModificationAssociation
{
    public long ReportModificationAssociationId { get; set; }

    public string ReportModificationAssociationDescription { get; set; } = null!;

    public Guid ReportModificationGuid { get; set; }

    public Guid RelatedReportModificationGuid { get; set; }

    public long RelatedReportModificationId { get; set; }

    public long ReportModificationId { get; set; }

    public int? ReportModificationRelationshipTypeId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ReportModification RelatedReportModification { get; set; } = null!;

    public virtual ReportModification ReportModification { get; set; } = null!;

    public virtual ReportModificationRelationshipTypeDim? ReportModificationRelationshipType { get; set; }
}
