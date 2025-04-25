using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedConfiscationDatum
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string? PlateNumber { get; set; }

    public string? TrafficCode { get; set; }

    public string? LicenseNumber { get; set; }

    public string? DriverName { get; set; }

    public string? ConfiscationName { get; set; }

    public string? ConfiscationLocation { get; set; }

    public string? ConfiscationStatus { get; set; }

    public int ConfiscationDocumentTypeId { get; set; }

    public int? ConfiscationStatusId { get; set; }

    public int ConfiscationLocationId { get; set; }

    public long? EmirateId { get; set; }

    public long? CityId { get; set; }

    public long? SectorId { get; set; }

    public long? RegionId { get; set; }

    public long? StreetId { get; set; }

    public int DriverDataId { get; set; }
}
