using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationAreaGuidView
{
    public Guid AreaGuid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? SourceName { get; set; }

    public string? AreaCategoryCode { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public Guid LocationAreaGuid { get; set; }

    public string LocationAreaDescription { get; set; } = null!;

    public Guid LocationGuid { get; set; }

    public string? AreaInvolvementCode { get; set; }
}
