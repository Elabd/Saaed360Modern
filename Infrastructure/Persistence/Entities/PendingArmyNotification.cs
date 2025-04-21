using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PendingArmyNotification
{
    public string? PlateNumber { get; set; }

    public int VehicleDataId { get; set; }

    public int? VehicleDataTypeId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public long? AdpreportNumber { get; set; }
}
