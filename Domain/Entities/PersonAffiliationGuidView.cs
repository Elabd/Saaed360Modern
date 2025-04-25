using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonAffiliationGuidView
{
    public Guid PersonAffiliationGuid { get; set; }

    public string PersonAffiliationDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
