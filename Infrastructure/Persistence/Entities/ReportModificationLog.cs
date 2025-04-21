using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportModificationLog
{
    public long ReportModificationLogId { get; set; }

    public long? StateId { get; set; }

    public long? ReportModificationId { get; set; }

    public int? ReportModificationLogStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Comment { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ReportModifcationLogComment> ReportModifcationLogComments { get; set; } = new List<ReportModifcationLogComment>();

    public virtual ReportModification? ReportModification { get; set; }

    public virtual ReportModificationLogStatusDim? ReportModificationLogStatus { get; set; }

    public virtual State? State { get; set; }
}
