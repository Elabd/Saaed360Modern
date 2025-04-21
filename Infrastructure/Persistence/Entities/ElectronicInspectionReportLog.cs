using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportLog
{
    public long Id { get; set; }

    public long ElectronicInspectionReportId { get; set; }

    public long ActionUserId { get; set; }

    public string ActionUserName { get; set; } = null!;

    public DateTime ActionDateTime { get; set; }

    public long ElectronicInspectionReportStatusId { get; set; }

    public string? ElectronicInspectionReportStatus { get; set; }

    public string? Comment { get; set; }

    public string? UserName { get; set; }

    public virtual ElectronicInspectionReport ElectronicInspectionReport { get; set; } = null!;

    public virtual ElectronicInspectionReportStatus ElectronicInspectionReportStatusNavigation { get; set; } = null!;
}
