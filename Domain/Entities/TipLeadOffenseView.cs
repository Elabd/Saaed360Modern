using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipLeadOffenseView
{
    public long TipLeadOffenseId { get; set; }

    public long ActivityId { get; set; }

    public string? OffenseCodeCode { get; set; }

    public string? OffenseCodeDescription { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
