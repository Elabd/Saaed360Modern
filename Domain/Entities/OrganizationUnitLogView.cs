using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitLogView
{
    public long OrganizationUnitLogId { get; set; }

    public string OrganizationUnitLogDescription { get; set; } = null!;

    public long OrganizationUnitId { get; set; }

    public long? ItemId { get; set; }

    public string? Vehicle { get; set; }

    public DateTime? OnTime { get; set; }

    public DateTime? OffTime { get; set; }

    public string? OrganizationUnitStatusCode { get; set; }

    public string? OrganizationUnitStatusDescription { get; set; }

    public string? OrganizationUnitCategoryCode { get; set; }

    public string? OrganizationUnitCategoryDescription { get; set; }

    public string? OrganizationLogCategoryCode { get; set; }

    public string? OrganizationLogCategoryDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
