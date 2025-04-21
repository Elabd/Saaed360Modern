using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonCitizenshipGuidView
{
    public Guid PersonCitizenshipGuid { get; set; }

    public string PersonCitizenshipDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? GeoCountryCode { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
