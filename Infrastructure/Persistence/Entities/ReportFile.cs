using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportFile
{
    public long ReportFileId { get; set; }

    public int ReportId { get; set; }

    public long FileId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual File File { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;
}
