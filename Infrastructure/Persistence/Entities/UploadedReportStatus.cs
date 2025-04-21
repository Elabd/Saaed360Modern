using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UploadedReportStatus
{
    public long UploadedReportStatusId { get; set; }

    public int? ReportId { get; set; }

    public bool? IsUploaded { get; set; }

    public string? ErrorMessgae { get; set; }

    public int? RetryCount { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDatetime { get; set; }

    public string? SystemCode { get; set; }

    public long? AdpreportNumber { get; set; }

    public int? ReportYear { get; set; }

    public int? UploadedMethod { get; set; }

    public int ReportSequenceId { get; set; }

    public int CityId { get; set; }

    public virtual Report? Report { get; set; }
}
