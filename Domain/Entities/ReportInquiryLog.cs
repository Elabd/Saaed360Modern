using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportInquiryLog
{
    public long ReportInquiryLogId { get; set; }

    public int ReportId { get; set; }

    public DateTime LogCreationDate { get; set; }

    public virtual Report Report { get; set; } = null!;
}
