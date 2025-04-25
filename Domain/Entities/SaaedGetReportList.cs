using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedGetReportList
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? ReportTypeId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string? ReportStatus { get; set; }

    public string? ReportType { get; set; }

    public string? IncidentNumber { get; set; }

    public long? IncidentId { get; set; }

    public bool? IsUploaded { get; set; }

    public string? ReportType1 { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public long? EmirateId { get; set; }

    public long? CityId { get; set; }

    public long? SectorId { get; set; }

    public long? RegionId { get; set; }

    public long? StreetId { get; set; }

    public long? IncidentAreaId { get; set; }

    public string? ErrorMsg { get; set; }

    public int? LastActionTaken { get; set; }

    public bool? IsNeedAmbulance { get; set; }

    public string? InjuredNames { get; set; }

    public DateTime? AmbulanceDate { get; set; }

    public long? AdpreportNumber { get; set; }
}
