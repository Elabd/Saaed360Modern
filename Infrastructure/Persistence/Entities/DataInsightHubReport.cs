using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DataInsightHubReport
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public string DescriptionAr { get; set; } = null!;

    public int ReportCategoryId { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<DataInsightHubReportDisplayColumn> DataInsightHubReportDisplayColumns { get; set; } = new List<DataInsightHubReportDisplayColumn>();

    public virtual ICollection<PersonReportsAssignment> PersonReportsAssignments { get; set; } = new List<PersonReportsAssignment>();

    public virtual DataInsightHubReportCategory ReportCategory { get; set; } = null!;
}
