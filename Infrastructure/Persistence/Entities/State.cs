using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class State
{
    public long StateId { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public int Rank { get; set; }

    public long? ApprovalCycleId { get; set; }

    public Guid? ResponsibleRoleId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? ForExternalUsers { get; set; }

    public virtual ApprovalCycle? ApprovalCycle { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ReportModificationLog> ReportModificationLogs { get; set; } = new List<ReportModificationLog>();

    public virtual AspnetRole? ResponsibleRole { get; set; }

    public virtual ICollection<StateNotificationRole> StateNotificationRoles { get; set; } = new List<StateNotificationRole>();
}
