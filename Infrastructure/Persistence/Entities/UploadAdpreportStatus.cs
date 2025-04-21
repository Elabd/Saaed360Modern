using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UploadAdpreportStatus
{
    public int Id { get; set; }

    public int? ReportId { get; set; }

    public long? AdpreportNumber { get; set; }

    public string? ErrorMessgae { get; set; }

    public string? StatusId { get; set; }

    public int? AdpstatusId { get; set; }

    public DateTime? LastSyncTime { get; set; }

    public DateTime? PayDate { get; set; }
}
