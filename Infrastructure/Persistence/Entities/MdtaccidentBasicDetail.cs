using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtaccidentBasicDetail
{
    public int MdtaccidentBasicDetailsId { get; set; }

    public long? EmiratesId { get; set; }

    public long? CityId { get; set; }

    public long? RegionId { get; set; }

    public long? SectorId { get; set; }

    public long? StreetId { get; set; }

    public long? CrossingStreetId { get; set; }

    public string? NorthernCoOrdinate { get; set; }

    public string? EasternCoOrdinate { get; set; }

    public string? LocationDescription { get; set; }

    public int? AccidentTypeId { get; set; }

    public int? WeatherId { get; set; }

    public int? RoadSurfaceId { get; set; }

    public int? RoadSpeedId { get; set; }

    public int? IntersectionId { get; set; }

    public bool? ReportReconstructionWillBeContinued { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? ScenarioId { get; set; }

    public string? AccidentReasonComment { get; set; }

    public string? Comment { get; set; }

    public string? AccidentTypeComment { get; set; }

    public string? IntersectionComment { get; set; }

    public long? CollisionTypeId { get; set; }

    public long? AccidentLocationDescriptionId { get; set; }

    public bool? IsMonitoringWithCamera { get; set; }

    public virtual AccidentLocationDescriptionDim? AccidentLocationDescription { get; set; }

    public virtual AccidentTypeDim? AccidentType { get; set; }

    public virtual CityDim? City { get; set; }

    public virtual CollisionTypeDim? CollisionType { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual CrossStreetDim? CrossingStreet { get; set; }

    public virtual EmirateDim? Emirates { get; set; }

    public virtual IntersectionDim? Intersection { get; set; }

    public virtual ReportAreaDim? Region { get; set; }

    public virtual ICollection<ReportMdtAccidentBasicDetail> ReportMdtAccidentBasicDetails { get; set; } = new List<ReportMdtAccidentBasicDetail>();

    public virtual RoadSpeedDim? RoadSpeed { get; set; }

    public virtual RoadSurfaceDim? RoadSurface { get; set; }

    public virtual ScenarioDim? Scenario { get; set; }

    public virtual SectorDim? Sector { get; set; }

    public virtual StreetDim? Street { get; set; }

    public virtual WeatherDim? Weather { get; set; }
}
