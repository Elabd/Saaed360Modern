using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VMobileRequestList
{
    public long Id { get; set; }

    public DateTime Date { get; set; }

    public string? PhoneNumber { get; set; }

    public int StatusId { get; set; }

    public string? StatusAr { get; set; }

    public string? StatusEn { get; set; }

    public int? PlanningStatusId { get; set; }

    public string? PlanningStatusCode { get; set; }

    public string? PlanningStatusAr { get; set; }

    public string? PlanningStatusEn { get; set; }

    public int IsDisplayedInRequestsList { get; set; }

    public string? PlanningStatusDisplayAr { get; set; }

    public string? PlanningStatusDisplayEn { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDate { get; set; }

    public int? ReportStatusId { get; set; }

    public string? ReportStatusAr { get; set; }

    public string? ReportStatusCode { get; set; }

    public long AreaId { get; set; }

    public string? Area { get; set; }

    public long? EmirateId { get; set; }

    public string? EmirateAr { get; set; }

    public string? EmirateEn { get; set; }
}
