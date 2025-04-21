using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonImageContainerGuidView
{
    public Guid PersonImageGuid { get; set; }

    public string PersonImageDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid ImageGuid { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
