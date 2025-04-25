using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonAffiliationView
{
    public long PersonAffiliationId { get; set; }

    public string PersonAffiliationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long OrganizationId { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
