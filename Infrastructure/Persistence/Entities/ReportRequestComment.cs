using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportRequestComment
{
    public long ReportRequestCommentId { get; set; }

    public long? ReportRequestId { get; set; }

    public string? Comment { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ReportRequest? ReportRequest { get; set; }
}
