using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationUnitPersonnelGuidView
{
    public Guid OrganizationUnitPersonnelGuid { get; set; }

    public string OrganizationUnitPersonnelDescription { get; set; } = null!;

    public Guid OrganizationUnitGuid { get; set; }

    public Guid OrganzationPersonGuid { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
