using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentsFullDetail
{
    public long IncidentsFullDetailsId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public string? IncidentMasterId { get; set; }

    public DateTime? IncidentDatetime { get; set; }

    public string? PoliceNo { get; set; }

    public DateTime? PoliceDatetime { get; set; }

    public string? Description { get; set; }

    public string? IncidentSourceDescription { get; set; }

    public long? UserId { get; set; }

    public string? UserFullName { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? IncidentTypeDescription { get; set; }

    public string? SeverityStatus { get; set; }

    public string? Emi { get; set; }

    public string? City { get; set; }

    public string? Area { get; set; }

    public string? CallTakerName { get; set; }

    public string? DispatcherName { get; set; }

    public string? TrafficExpertName { get; set; }

    public string? PatrolCode { get; set; }

    public DateTime? IncidentAssignmentDatetime { get; set; }

    public DateTime? TrafficExpertReceiveDatetime { get; set; }

    public DateTime? FirstArrivalDatetime { get; set; }

    public string? FirstArrivalReasons { get; set; }

    public DateTime? SecondArrivalStartDatetime { get; set; }

    public DateTime? SecondArrivalEndDatetime { get; set; }

    public string? SecondArrivalReasons { get; set; }

    public DateTime? SketchStartDatetime { get; set; }

    public DateTime? SketchEndDatetime { get; set; }

    public string? SketchingReasons { get; set; }

    public DateTime? TransferToPoliceCenterDatetime { get; set; }

    public string? TransferToPoliceCenterReasons { get; set; }

    public DateTime? HandOverDocumentsDatetime { get; set; }

    public DateTime? ClosingStartDatetime { get; set; }

    public DateTime? ClosingEndDatetime { get; set; }

    public string? ClosingReasons { get; set; }

    public string? ClosingComment { get; set; }
}
