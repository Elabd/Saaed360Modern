using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortingReportBasicDetail
{
    public long EscortingReportBasicDetailsId { get; set; }

    public string? ReportDescription { get; set; }

    public int? ReportId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Report? Report { get; set; }
}
