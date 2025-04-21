using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewIncident
{
    public long? ActivityId { get; set; }

    public string? ActivityDescription { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public long LocationId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Address { get; set; }

    public int? ServiceCallIncidentTypeId { get; set; }

    public string? IncidentType { get; set; }

    public int? ServiceCallPriorityId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public int? StatusId { get; set; }

    public long? CreatedBy { get; set; }

    public string? CloseReason { get; set; }

    public long Id { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public int? ActivityCategoryId { get; set; }

    public string? Owner { get; set; }

    public long? OwnerId { get; set; }

    public string? Priority { get; set; }

    public bool? IncidentDelayed { get; set; }

    public Guid? WorkflowGuid { get; set; }

    public bool? AutomaticIncident { get; set; }

    public bool? IsConvertedToPoliceStation { get; set; }

    public bool? IsDeliveredToPoliceStation { get; set; }

    public Guid? ConvertToStaionWfId { get; set; }

    public string? ConvertReason { get; set; }

    public string? ConvertOrganization { get; set; }

    public bool? IsAnsweringTimeExist { get; set; }

    public DateTime? AnsweringTime { get; set; }

    public long? IcccdispatcherId { get; set; }

    public bool? IsAutoDispatch { get; set; }
}
