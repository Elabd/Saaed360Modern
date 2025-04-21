using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class WarrantAppearanceBailContainerGuidView
{
    public Guid WarrantAppearanceBailGuid { get; set; }

    public string WarrantAppearanceBailDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
