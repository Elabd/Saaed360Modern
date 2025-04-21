using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewUnderProcessLog
{
    public string? Comment { get; set; }

    public DateTime CreationTime { get; set; }

    public long ReportId { get; set; }

    public long UserId { get; set; }

    public string EmployeeName { get; set; } = null!;
}
