using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DataInsightHubReportDisplayColumn
{
    public int Id { get; set; }

    public int? ReportId { get; set; }

    public string? ColumnDisplayNameEn { get; set; }

    public string? ColumnDisplayNameAr { get; set; }

    public string? SpsColumnName { get; set; }

    public int? ColumnOrder { get; set; }

    public bool? IsVisible { get; set; }

    public virtual DataInsightHubReport? Report { get; set; }
}
