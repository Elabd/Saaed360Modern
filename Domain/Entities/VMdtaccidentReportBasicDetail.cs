using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VMdtaccidentReportBasicDetail
{
    public int ReportId { get; set; }

    public long ActivityId { get; set; }

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

    public string? ReportType { get; set; }

    public string? ReportTypeCode { get; set; }

    public string? ReportStatus { get; set; }

    public string? ReportStatusCode { get; set; }

    public bool? IsDraftStatus { get; set; }

    public int? MappedFinalStatusId { get; set; }

    public string? Emirate { get; set; }

    public string? City { get; set; }

    public string? Area { get; set; }

    public string? Sector { get; set; }

    public string? Street { get; set; }

    public string? CrossStreet { get; set; }

    public string? AccidentType { get; set; }

    public string? AccidentTypeCode { get; set; }

    public string? Weather { get; set; }

    public string? RoadSurface { get; set; }

    public string? Intersection { get; set; }

    public string? IntersectionCode { get; set; }

    public string? Scenario { get; set; }

    public string? ScenarioCode { get; set; }

    public string? RoadSpeed { get; set; }

    public string? AccidentReasonComment { get; set; }

    public string? Comment { get; set; }

    public string? IntersectionComment { get; set; }

    public string? AccidentTypeComment { get; set; }

    public bool? IsTransferedFromPolice { get; set; }

    public DateTime? ActualAccidentDate { get; set; }

    public string? CollisionDescription { get; set; }

    public string? AccidentLocation { get; set; }

    public long? CollisionTypeId { get; set; }

    public long? AccidentLocationDescriptionId { get; set; }

    public bool? IsMonitoringWithCamera { get; set; }

    public int? ReportSourceTypeId { get; set; }

    public string? ReportSourceTypeCode { get; set; }

    public long? ReportSourceId { get; set; }

    public long? OrganizationId { get; set; }

    public int? ActivityReasonId { get; set; }

    public string? Organization { get; set; }

    public string? ActivityReason { get; set; }
}
