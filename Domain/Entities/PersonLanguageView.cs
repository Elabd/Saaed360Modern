using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonLanguageView
{
    public long PersonLanguageId { get; set; }

    public string PersonLanguageDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? LanguageCode { get; set; }

    public string? LanguageDescription { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsSpoken { get; set; }

    public bool? IsRead { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
