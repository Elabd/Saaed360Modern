using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PurchaseRequestViewHelper
{
    public long PurchaseRequestId { get; set; }

    public bool? IsDelayed { get; set; }

    public int LastStatusId { get; set; }

    public int ReportId { get; set; }

    public DateTime CreateDate { get; set; }

    public string? ReportNumber { get; set; }

    public string? PlateNumber { get; set; }

    public string? PlateSource { get; set; }

    public string? PlateColor { get; set; }

    public string? ChasisNumber { get; set; }

    public string? TrafficCode { get; set; }

    public string? Name { get; set; }

    public string? MobileNumber { get; set; }

    public string PurchaseRequestStatusArabic { get; set; } = null!;

    public string PurchaseRequestStatusEnglish { get; set; } = null!;
}
