using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonCitizenshipView
{
    public long PersonCitizenshipId { get; set; }

    public string PersonCitizenshipDescription { get; set; } = null!;

    public long? PersonId { get; set; }

    public string? GeoCountryCode { get; set; }

    public string? GeoCountryCountryName { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
