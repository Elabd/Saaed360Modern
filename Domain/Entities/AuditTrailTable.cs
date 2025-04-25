using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AuditTrailTable
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string OldValue { get; set; } = null!;

    public string NewValue { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string FieldIdNumber { get; set; } = null!;

    public DateTime TimeStamp { get; set; }
}
