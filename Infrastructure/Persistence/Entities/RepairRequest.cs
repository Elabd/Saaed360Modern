using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairRequest
{
    public long Id { get; set; }

    public int ReportId { get; set; }

    public int VehicleDataId { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? IsDelayed { get; set; }

    public long? LastModifiedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public long EmirateDimId { get; set; }

    public long AreaId { get; set; }

    public string? ContactEmail { get; set; }

    public bool IsQuotesNotificationSent { get; set; }

    public int RepairStatusId { get; set; }

    public string? PreferredCommunicationLanguage { get; set; }

    public long? AwarededRequestGarageId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime ExpectedDeliveryDate { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual RepairRequestGarage? AwarededRequestGarage { get; set; }

    public virtual EmirateDim EmirateDim { get; set; } = null!;

    public virtual Person? LastModifiedByNavigation { get; set; }

    public virtual ICollection<RepairComment> RepairComments { get; set; } = new List<RepairComment>();

    public virtual ICollection<RepairCompleteLog> RepairCompleteLogs { get; set; } = new List<RepairCompleteLog>();

    public virtual ICollection<RepairLog> RepairLogs { get; set; } = new List<RepairLog>();

    public virtual ICollection<RepairNotificationLog> RepairNotificationLogs { get; set; } = new List<RepairNotificationLog>();

    public virtual ICollection<RepairNotification> RepairNotifications { get; set; } = new List<RepairNotification>();

    public virtual ICollection<RepairRequestGarage> RepairRequestGarages { get; set; } = new List<RepairRequestGarage>();

    public virtual ICollection<RepairRequestStatusHistory> RepairRequestStatusHistories { get; set; } = new List<RepairRequestStatusHistory>();

    public virtual RepairStatusDim RepairStatus { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual VehicleDatum VehicleData { get; set; } = null!;
}
