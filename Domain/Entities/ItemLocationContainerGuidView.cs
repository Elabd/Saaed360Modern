using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemLocationContainerGuidView
{
    public Guid ItemLocationGuid { get; set; }

    public string ItemLocationDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public Guid LocationGuid { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
