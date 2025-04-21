using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequest
{
    public long RequestNumber { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Description { get; set; }

    public string? ReportNumber { get; set; }

    public int? MobileRequestStatusId { get; set; }

    public long? ActivityId { get; set; }

    public int? ReportId { get; set; }

    public string? DeviceCode { get; set; }

    public DateTime CreateDate { get; set; }

    public bool? IsModified { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? IncidentTypeId { get; set; }

    public long? AreaId { get; set; }

    public string? Address { get; set; }

    public long? ReceivedPersonId { get; set; }

    public DateTime? ReceivedTime { get; set; }

    public int? ChannelId { get; set; }

    public DateTime? CompletionDate { get; set; }

    public int? ReportPlanningStatusId { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual Area? Area { get; set; }

    public virtual ICollection<MobileMessage> MobileMessages { get; set; } = new List<MobileMessage>();

    public virtual ICollection<MobileNotification> MobileNotifications { get; set; } = new List<MobileNotification>();

    public virtual ICollection<MobileRequestComment> MobileRequestComments { get; set; } = new List<MobileRequestComment>();

    public virtual MobileRequestStatusDim? MobileRequestStatus { get; set; }

    public virtual ICollection<MobileRequestSurvey> MobileRequestSurveys { get; set; } = new List<MobileRequestSurvey>();

    public virtual ICollection<MobileRequestTransaction> MobileRequestTransactions { get; set; } = new List<MobileRequestTransaction>();

    public virtual ICollection<MobileRequestVehicle> MobileRequestVehicles { get; set; } = new List<MobileRequestVehicle>();

    public virtual Person? ReceivedPerson { get; set; }

    public virtual Report? Report { get; set; }

    public virtual MobileRequestReportPlanningStatusDim? ReportPlanningStatus { get; set; }
}
