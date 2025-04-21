using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedReportControlCenterCheckupTool
{
    public long ActivityId { get; set; }

    public string? Tool { get; set; }

    public string SourceOfCheckup { get; set; } = null!;

    public string? PatrolCode { get; set; }

    public string UserFullName { get; set; } = null!;

    public string? Comment { get; set; }

    public DateTime? CheckupDate { get; set; }

    public string? ControlCenter { get; set; }
}
