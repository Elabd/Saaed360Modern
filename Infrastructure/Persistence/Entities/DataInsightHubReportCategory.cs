using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DataInsightHubReportCategory
{
    public int Id { get; set; }

    public string NameEn { get; set; } = null!;

    public string NameAr { get; set; } = null!;

    public int? ParentCategoryId { get; set; }

    public virtual ICollection<DataInsightHubReport> DataInsightHubReports { get; set; } = new List<DataInsightHubReport>();
}
