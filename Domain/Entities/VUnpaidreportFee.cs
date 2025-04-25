using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VUnpaidreportFee
{
    public int ReportId { get; set; }

    public int VehicleDataId { get; set; }

    public DateTime? UploadedTime { get; set; }

    public int? PlateSourceId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public long? AdpreportNumber { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? ReportCode { get; set; }

    public string? MobileNumber { get; set; }
}
