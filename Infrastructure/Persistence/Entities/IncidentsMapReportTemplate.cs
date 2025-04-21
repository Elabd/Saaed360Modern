using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentsMapReportTemplate
{
    public int Id { get; set; }

    public string? TemplateName { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? CreatedByUserId { get; set; }

    public long? ControlRoomOrganizationId { get; set; }

    public string? AreaId { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int? MeasurementTime { get; set; }

    public int? IncidentStatusId { get; set; }

    public string? ServiceCallIncidentTypeId { get; set; }

    public string? ReportTypeId { get; set; }

    public string? ReportReasonId { get; set; }

    public string? LocationsList { get; set; }

    public bool? IsPoliceIncident { get; set; }

    public bool? IsLateIncident { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? Distance { get; set; }

    public bool? IsDeleted { get; set; }
}

