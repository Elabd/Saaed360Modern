using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemImageContainerGuidView
{
    public Guid ItemImageGuid { get; set; }

    public string ItemImageDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public Guid ImageGuid { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
