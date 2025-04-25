using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedIplateNumbersIntegrationLog
{
    public Guid PlateNumberIntegrationId { get; set; }

    public DateTime? CreationDate { get; set; }

    public int ReportId { get; set; }

    public string? PlateNumber { get; set; }

    public int? ColorId { get; set; }

    public int? SourceId { get; set; }

    public int? VehicleDataId { get; set; }

    public int? CategoryId { get; set; }

    public int? KindId { get; set; }

    public virtual Report Report { get; set; } = null!;

    public virtual VehicleDatum? VehicleData { get; set; }
}

