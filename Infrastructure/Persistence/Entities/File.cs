using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class File
{
    public long FileId { get; set; }

    public Guid FileGuid { get; set; }

    public string FileName { get; set; } = null!;

    public long? FileCategoryId { get; set; }

    public byte[] FileBytes { get; set; } = null!;

    public string? Recepient { get; set; }

    public bool? SendSuccessFully { get; set; }

    public int? RetryCount { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? RowStatusId { get; set; }

    public string? EmailBody { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual FileCategoryDim? FileCategory { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ReportFile> ReportFiles { get; set; } = new List<ReportFile>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
