using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportCode
{
    public long ReportCodeId { get; set; }

    public string RandomCode { get; set; } = null!;

    public string ReportNumber { get; set; } = null!;

    public string PlateNumber { get; set; } = null!;

    public string Smstext { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public DateTime? SendDateTime { get; set; }
}
