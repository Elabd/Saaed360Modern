using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportModificationType
{
    public int ReportModificationTypeId { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ReportModification> ReportModifications { get; set; } = new List<ReportModification>();
}
