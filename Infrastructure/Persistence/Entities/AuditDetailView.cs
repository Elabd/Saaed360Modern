using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AuditDetailView
{
    public long AuditDetailId { get; set; }

    public string AuditDetailDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? AuditCategoryCode { get; set; }

    public string? AuditCategoryDescription { get; set; }

    public string? AuditXml { get; set; }

    public DateTime? AuditDateTime { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
