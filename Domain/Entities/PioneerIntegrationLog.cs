using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PioneerIntegrationLog
{
    public long Id { get; set; }

    public long? ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? Earcid { get; set; }

    public bool? IsSaved { get; set; }

    public string? CreatedBy { get; set; }

    public string? FullName { get; set; }
}
