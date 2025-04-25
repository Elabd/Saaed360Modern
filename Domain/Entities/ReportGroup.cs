using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportGroup
{
    public long GroupId { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public long? ApprovalCycleId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? CultureDescriptionXml { get; set; }

    public virtual ApprovalCycle? ApprovalCycle { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<ReportField> ReportFields { get; set; } = new List<ReportField>();
}
