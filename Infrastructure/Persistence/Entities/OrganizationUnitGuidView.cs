using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationUnitGuidView
{
    public Guid OrganizationUnitGuid { get; set; }

    public string OrganizationUnitDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public Guid? PrimaryPersonGuid { get; set; }

    public string? OrganizationUnitCategoryCode { get; set; }

    public string? OrganizationStatusCode { get; set; }

    public string? UnitName { get; set; }

    public string? OriginalIdent { get; set; }

    public string? UnitAbbreviation { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
