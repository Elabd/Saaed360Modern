using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArrestWarrantContainerView
{
    public long ArrestWarrantId { get; set; }

    public string ArrestWarrantDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
