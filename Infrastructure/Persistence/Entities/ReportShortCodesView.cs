using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportShortCodesView
{
    public string? ReportNumber { get; set; }

    public string? ShortNumber { get; set; }

    public int ReportId { get; set; }
}
