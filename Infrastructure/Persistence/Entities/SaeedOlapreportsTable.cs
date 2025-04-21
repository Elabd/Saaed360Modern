using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaeedOlapreportsTable
{
    public int Pkid { get; set; }

    public string ReportName { get; set; } = null!;

    public int FkReportTypeId { get; set; }

    public string ReportPath { get; set; } = null!;

    public string ReportDescription { get; set; } = null!;

    public bool HasCrfilter { get; set; }

    public bool HasEmirateFilter { get; set; }

    public bool HasDateRangeFilter { get; set; }

    public bool HasYearFilter { get; set; }

    public bool HasSelectedMonthFilter { get; set; }

    public bool HasSelectedWeekFilter { get; set; }

    public bool HasSelectedDayFilter { get; set; }

    public string? FilterRelations { get; set; }

    public int? ParamsNumber { get; set; }

    public virtual SaeedOlapreportsType FkReportType { get; set; } = null!;
}
