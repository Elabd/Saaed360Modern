using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Saaed360ViewIncidentAssignedPatrol
{
    public long PatrolId { get; set; }

    public long IncidentId { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public long PatrolAssignmentId { get; set; }

    public string? PatrolStatus { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? IncidentStatus { get; set; }

    public long Id { get; set; }

    public string? ActivityDescription { get; set; }

    public long AreaId { get; set; }

    public string? AreaName { get; set; }

    public long? LandmarkId { get; set; }

    public string? LandmarkName { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Address { get; set; }

    public int? ServiceCallPriorityId { get; set; }

    public int? ActivityCategoryId { get; set; }

    public int? ServiceCallIncidentTypeId { get; set; }

    public int? IncidentStatusId { get; set; }

    public string? IncidentType { get; set; }

    public string? Owner { get; set; }

    public bool? IsConvertedToPoliceStation { get; set; }

    public bool? IsDeliveredToPoliceStation { get; set; }

    public Guid? ConvertToStaionWfId { get; set; }

    public string? ConvertOrganization { get; set; }

    public string? ConvertReason { get; set; }
}
