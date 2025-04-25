using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AuditDetailGuidView
{
    public Guid AuditDetailGuid { get; set; }

    public string AuditDetailDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? AuditCategoryCode { get; set; }

    public string? AuditXml { get; set; }

    public DateTime? AuditDateTime { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
