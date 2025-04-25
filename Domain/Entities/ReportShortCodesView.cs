using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportShortCodesView
{
    public string? ReportNumber { get; set; }

    public string? ShortNumber { get; set; }

    public int ReportId { get; set; }
}
