using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityDrugContainerGuidView
{
    public Guid ActivityItemGuid { get; set; }

    public string ActivityItemDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid ItemGuid { get; set; }

    public string? SourceName { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
