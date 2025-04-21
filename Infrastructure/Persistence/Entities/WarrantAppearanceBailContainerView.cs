using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class WarrantAppearanceBailContainerView
{
    public long WarrantAppearanceBailId { get; set; }

    public string WarrantAppearanceBailDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
