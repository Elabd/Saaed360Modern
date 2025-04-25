using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportModification
{
    public long ReportModificationId { get; set; }

    public long? ReportRequestId { get; set; }

    public int? ReportId { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public long? RowId { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int? ReportModificationStatusId { get; set; }

    public int? ReportModificationTypeId { get; set; }

    public Guid? Guid { get; set; }

    public long? FieldId { get; set; }

    public string? ParentId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? ReasonForModification { get; set; }

    public int? Order { get; set; }

    public string? Comments { get; set; }

    public string? NewValueToBeShown { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ReportField? Field { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Report? Report { get; set; }

    public virtual ICollection<ReportModificationAssociation> ReportModificationAssociationRelatedReportModifications { get; set; } = new List<ReportModificationAssociation>();

    public virtual ICollection<ReportModificationAssociation> ReportModificationAssociationReportModifications { get; set; } = new List<ReportModificationAssociation>();

    public virtual ICollection<ReportModificationLog> ReportModificationLogs { get; set; } = new List<ReportModificationLog>();

    public virtual ReportModificationStatus? ReportModificationStatus { get; set; }

    public virtual ReportModificationType? ReportModificationType { get; set; }

    public virtual ReportRequest? ReportRequest { get; set; }
}
