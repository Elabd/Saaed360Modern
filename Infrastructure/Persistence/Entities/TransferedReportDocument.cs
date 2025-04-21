using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TransferedReportDocument
{
    public long TransferedReportDocumentId { get; set; }

    public string? DocumentName { get; set; }

    public string? BinaryDescriptionText { get; set; }

    public byte[]? BinaryBase64Object { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? ReportId { get; set; }

    public string? Comments { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Report? Report { get; set; }
}
