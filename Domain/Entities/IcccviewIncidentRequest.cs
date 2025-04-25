using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewIncidentRequest
{
    public long ActivityId { get; set; }

    public string? ActivityDescription { get; set; }

    public string IncidentGeneratedNumber { get; set; } = null!;

    public long LocationId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Address { get; set; }

    public int? ServiceCallIncidentTypeId { get; set; }

    public string? IncidentType { get; set; }

    public int? ServiceCallPriorityId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public int StatusId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public long? ActivityCategoryId { get; set; }

    public string? Owner { get; set; }

    public Guid? WorkflowGuid { get; set; }

    public long? LandmarkId { get; set; }

    public long EmiratesId { get; set; }

    public long? AreaId { get; set; }

    public string? ContactName { get; set; }

    public string? ContactInformation { get; set; }

    public string? Code { get; set; }
}
