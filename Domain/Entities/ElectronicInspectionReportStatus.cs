using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ElectronicInspectionReportStatus
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<ElectronicInspectionReportLog> ElectronicInspectionReportLogs { get; set; } = new List<ElectronicInspectionReportLog>();

    public virtual ICollection<ElectronicInspectionReport> ElectronicInspectionReports { get; set; } = new List<ElectronicInspectionReport>();
}
