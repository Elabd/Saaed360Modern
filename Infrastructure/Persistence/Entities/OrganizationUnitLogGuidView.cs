using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationUnitLogGuidView
{
    public Guid OrganizationUnitLogGuid { get; set; }

    public string OrganizationUnitLogDescription { get; set; } = null!;

    public Guid OrganizationUnitGuid { get; set; }

    public Guid ItemGuid { get; set; }

    public string? Vehicle { get; set; }

    public DateTime? OnTime { get; set; }

    public DateTime? OffTime { get; set; }

    public string? OrganizationUnitStatusCode { get; set; }

    public string? OrganizationUnitCategoryCode { get; set; }

    public string? OrganizationLogCategoryCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
