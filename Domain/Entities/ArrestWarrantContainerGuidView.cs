using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArrestWarrantContainerGuidView
{
    public Guid ArrestWarrantGuid { get; set; }

    public string ArrestWarrantDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
