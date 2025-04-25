using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SupportAuditDim
{
    public long SupportAuditId { get; set; }

    public int? Dimid { get; set; }

    public long? SourceId { get; set; }

    public string? TableName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
