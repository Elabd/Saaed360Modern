using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedSsrsreportsType
{
    public int Pkid { get; set; }

    public string ReportType { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public virtual ICollection<SaaedSsrsreportsTable> SaaedSsrsreportsTables { get; set; } = new List<SaaedSsrsreportsTable>();
}
