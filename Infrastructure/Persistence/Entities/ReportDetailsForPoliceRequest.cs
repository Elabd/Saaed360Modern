using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportDetailsForPoliceRequest
{
    public long ReportId { get; set; }

    public long Year { get; set; }

    public long Month { get; set; }

    public long Day { get; set; }

    public TimeOnly Time { get; set; }

    public string EmirateName { get; set; } = null!;

    public string EmirateCode { get; set; } = null!;

    public string CityName { get; set; } = null!;

    public string CityCode { get; set; } = null!;

    public string AreaName { get; set; } = null!;

    public string AreaCode { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string StreetCode { get; set; } = null!;

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string Reason { get; set; } = null!;

    public string ReasonCode { get; set; } = null!;

    public string? ReasonDescription { get; set; }

    public long Id { get; set; }

    public string? ReportNumber { get; set; }
}
