using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TipLeadOffenseGuidView
{
    public Guid TipLeadOffenseGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? OffenseCodeCode { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
