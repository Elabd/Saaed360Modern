using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtOrderWarrantContainerGuidView
{
    public Guid CourtOrderWarrantGuid { get; set; }

    public string CourtOrderWarrantDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
