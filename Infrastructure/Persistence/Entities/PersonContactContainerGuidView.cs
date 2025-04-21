using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonContactContainerGuidView
{
    public Guid PersonContactGuid { get; set; }

    public string PersonContactDescription { get; set; } = null!;

    public Guid ContactGuid { get; set; }

    public Guid PersonGuid { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
