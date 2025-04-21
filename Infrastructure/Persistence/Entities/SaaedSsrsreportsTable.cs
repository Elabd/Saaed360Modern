using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedSsrsreportsTable
{
    public int Pkid { get; set; }

    public string ReportName { get; set; } = null!;

    public int FkReportTypeId { get; set; }

    public string ReportPath { get; set; } = null!;

    public string ReportDescription { get; set; } = null!;

    public bool HasCrfilter { get; set; }

    public bool HasEmpFilter { get; set; }

    public bool HasEmirateFilter { get; set; }

    public bool HasAreaFilter { get; set; }

    public bool HasDateRangeFilter { get; set; }

    public bool HasTimeRangeFilter { get; set; }

    /// <summary>
    /// 1-EmpToCR 
    /// 2-ArToCR
    /// 3-EmpToArToCR
    /// 4-ArToEm
    /// 5-EmpToArToEm
    /// </summary>
    public string? FilterRelations { get; set; }

    public string? Roles { get; set; }

    public int? ParamsNumber { get; set; }

    public bool? HasPatrolFilter { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual SaaedSsrsreportsType FkReportType { get; set; } = null!;
}
