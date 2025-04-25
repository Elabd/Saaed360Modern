using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Audit
{
    public long ActivityId { get; set; }

    public int? AuditCategoryId { get; set; }

    public int? AuthorizationTypeId { get; set; }

    public string? AuditXml { get; set; }

    public DateTime? AuditDateTime { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual AuditCategoryDim? AuditCategory { get; set; }

    public virtual AuthorizationTypeDim? AuthorizationType { get; set; }
}
