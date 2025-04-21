using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetCreateAccidentMasterDatum
{
    public long ActivityId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime? ActivityDate { get; set; }

    public DateTime ReportDatetime { get; set; }

    public int? ReportTypeId { get; set; }

    public long? EmiratesId { get; set; }

    public long? CityId { get; set; }

    public long StreetId { get; set; }

    public string StreetCode { get; set; } = null!;

    public long CrossingStreetId { get; set; }

    public string CrossingStreetCode { get; set; } = null!;

    public int? WeatherId { get; set; }

    public int? RoadSpeedId { get; set; }

    public string RoadSpeed { get; set; } = null!;

    public int? IntersectionId { get; set; }

    public int? RoadSurfaceId { get; set; }

    public int AccidentTypeId { get; set; }

    public int? PropertyTypeId { get; set; }

    public int? IntSctcode { get; set; }

    public string? StrIntersectionDesc { get; set; }

    public string? StrStSurfaceDesc { get; set; }

    public string? StrAccKindDesc { get; set; }

    public string? StrGovProDesc { get; set; }

    public int ReportSequenceId { get; set; }

    public double Longitude { get; set; }

    public double Latitude { get; set; }
}
