using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedReportsTable
{
    public int Pkid { get; set; }

    public string ReportName { get; set; } = null!;

    public string ReportCode { get; set; } = null!;

    public string ReportDescription { get; set; } = null!;

    public bool HasTime { get; set; }

    public bool? IsDeleted { get; set; }
}
