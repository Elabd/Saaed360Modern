using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MdtaccidentReportBasicDetail
{
    public long ActivityId { get; set; }

    public int ReportId { get; set; }

    public long? CreatedBy { get; set; }

    public int MdtaccidentBasicDetailsId { get; set; }

    public bool? ReportReconstructionWillBeContinued { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public int? ReportTypeId { get; set; }

    public int? ReportStatusId { get; set; }

    public long? EmiratesId { get; set; }

    public long? CityId { get; set; }

    public long? CrossingStreetId { get; set; }

    public long? StreetId { get; set; }

    public long? RegionId { get; set; }

    public string? LocationDescription { get; set; }

    public int? AccidentTypeId { get; set; }

    public string? EasternCoOrdinate { get; set; }

    public string? NorthernCoOrdinate { get; set; }

    public int? WeatherId { get; set; }

    public int? RoadSurfaceId { get; set; }

    public int? RoadSpeedId { get; set; }

    public int? IntersectionId { get; set; }

    public long? SectorId { get; set; }

    public int? ScenarioId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public string? AccidentReasonComment { get; set; }

    public string? Comment { get; set; }
}
