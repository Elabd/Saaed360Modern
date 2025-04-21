using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VUploadAccidentDamagedPart
{
    public long ActivityId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? IntYear { get; set; }

    public long? EmiratesId { get; set; }

    public int? ReportTypeId { get; set; }

    public string LngSerial { get; set; } = null!;

    public string? DamagedPartsDetails { get; set; }

    public int? VehicleDataId { get; set; }

    public long? CreatedBy { get; set; }
}
