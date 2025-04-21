using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportDetailsForPoliceRequestView
{
    public long ReportId { get; set; }

    public DateOnly? ReportDate { get; set; }

    public string ReportEmirateName { get; set; } = null!;

    public string ReportEmirateCode { get; set; } = null!;

    public string ReportCityCode { get; set; } = null!;

    public string ReportCityName { get; set; } = null!;

    public string ReportAreaCode { get; set; } = null!;

    public string ReportAreaName { get; set; } = null!;

    public double ReportLatitude { get; set; }

    public double ReportLongitude { get; set; }
}
