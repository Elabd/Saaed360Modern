using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonFirearmContainerGuidView
{
    public Guid PersonItemGuid { get; set; }

    public string PersonItemDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid ItemGuid { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
