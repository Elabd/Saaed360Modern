using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitPersonnelView
{
    public long OrganizationUnitPersonnelId { get; set; }

    public string OrganizationUnitPersonnelDescription { get; set; } = null!;

    public long OrganizationUnitId { get; set; }

    public long OrganzationPersonId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
