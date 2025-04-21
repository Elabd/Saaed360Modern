using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserReportsView
{
    public long UserId { get; set; }

    public string? TrafficCode { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDate { get; set; }

    public int? ReportStatusId { get; set; }

    public bool? IsReportDeleted { get; set; }

    public string? ReportStatus { get; set; }

    public int TypeId { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeDescription { get; set; }

    public int VehicleId { get; set; }

    public string? PlateNumber { get; set; }

    public int SourceId { get; set; }

    public string? SourceDescription { get; set; }

    public bool SourceInEmirates { get; set; }

    public int CategoryId { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryDescription { get; set; }

    public string? ReportCode { get; set; }
}
