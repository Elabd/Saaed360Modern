using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionRenewLog
{
    public long Id { get; set; }

    public int? ReportVehicleDataId { get; set; }

    public long? ObjectionId { get; set; }

    public DateTime? ObjectionRenewDate { get; set; }
}
