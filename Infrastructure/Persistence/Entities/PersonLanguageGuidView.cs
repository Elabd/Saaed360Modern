using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonLanguageGuidView
{
    public Guid PersonLanguageGuid { get; set; }

    public string PersonLanguageDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? LanguageCode { get; set; }

    public bool? IsPrimary { get; set; }

    public bool? IsSpoken { get; set; }

    public bool? IsRead { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
