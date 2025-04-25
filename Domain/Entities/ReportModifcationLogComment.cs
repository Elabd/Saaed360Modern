using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportModifcationLogComment
{
    public long ReportModifcationLogCommentId { get; set; }

    public long? ReportModifcationLogId { get; set; }

    public string? Comment { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ReportModificationLog? ReportModifcationLog { get; set; }
}
