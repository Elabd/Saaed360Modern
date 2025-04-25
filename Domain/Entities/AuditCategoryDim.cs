using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AuditCategoryDim
{
    public int AuditCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<AuditDetail> AuditDetails { get; set; } = new List<AuditDetail>();

    public virtual ICollection<Audit> Audits { get; set; } = new List<Audit>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
