using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BireportsTable
{
    public int Id { get; set; }

    public string ReportName { get; set; } = null!;

    public int BireportTypeId { get; set; }

    public string ReportDescription { get; set; } = null!;

    public bool HasCrfilter { get; set; }

    public bool HasEmpFilter { get; set; }

    public bool HasEmirateFilter { get; set; }

    public bool HasAreaFilter { get; set; }

    public bool HasDateRangeFilter { get; set; }

    public bool HasTimeRangeFilter { get; set; }

    public bool HasPatrolFilter { get; set; }

    public string? FilterRelations { get; set; }

    public string? Roles { get; set; }

    public int? ParamsNumber { get; set; }

    public virtual BireportsType BireportType { get; set; } = null!;
}
