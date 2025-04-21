using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ApprovalCycle
{
    public long ApprovalCycleId { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public int? RequestTypeId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ReportGroup> ReportGroups { get; set; } = new List<ReportGroup>();

    public virtual ReportRequestTypeDim? RequestType { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
