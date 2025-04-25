using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityReport
{
    public int ActivityReportId { get; set; }

    public long? ActivityId { get; set; }

    public int? ReportId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ReportImageCount { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Report? Report { get; set; }
}
