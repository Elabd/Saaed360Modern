using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VFinancialInquiryReport
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? ReportTypeId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string? ReportStatus { get; set; }

    public string? ReportType { get; set; }

    public string? IncidentNumber { get; set; }

    public long? IncidentId { get; set; }

    public bool? IsUploaded { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public long? AdpreportNumber { get; set; }

    public string FinancialStatus { get; set; } = null!;

    public string? AdpStatus { get; set; }

    public int? AdpstatusId { get; set; }

    public string? ErrorMessgae { get; set; }

    public bool? ReuploadAction { get; set; }

    public bool? FinancialInquairy { get; set; }

    public long? DirectPaymentRequestId { get; set; }

    public long? EmiratesId { get; set; }

    public string EmirateName { get; set; } = null!;

    public int? PaymentMethod { get; set; }
}
