using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitView
{
    public long OrganizationUnitId { get; set; }

    public string OrganizationUnitDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public long? PrimaryPersonId { get; set; }

    public string? OrganizationUnitCategoryCode { get; set; }

    public string? OrganizationUnitCategoryDescription { get; set; }

    public string? OrganizationStatusCode { get; set; }

    public string? OrganizationStatusDescription { get; set; }

    public string? UnitName { get; set; }

    public string? OriginalIdent { get; set; }

    public string? UnitAbbreviation { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
