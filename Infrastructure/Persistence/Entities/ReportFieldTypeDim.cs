using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportFieldTypeDim
{
    public int ReportFieldTypeId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Desc { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ReportField> ReportFields { get; set; } = new List<ReportField>();
}
