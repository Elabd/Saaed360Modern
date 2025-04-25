using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CopartSmslog
{
    public long CopartLogId { get; set; }

    public string MobileNumber { get; set; } = null!;

    public long VehicleDataId { get; set; }

    public long ReportId { get; set; }

    public DateTime SendDate { get; set; }
}
