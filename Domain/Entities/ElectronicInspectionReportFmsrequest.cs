using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ElectronicInspectionReportFmsrequest
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public long? ReportId { get; set; }

    public DateTime? RequestDate { get; set; }
}
