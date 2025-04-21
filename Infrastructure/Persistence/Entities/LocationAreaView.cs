using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationAreaView
{
    public long AreaId { get; set; }

    public long OrganizationId { get; set; }

    public string? SourceName { get; set; }

    public string? AreaCategoryCode { get; set; }

    public string? AreaCategoryDescription { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public long LocationAreaId { get; set; }

    public string LocationAreaDescription { get; set; } = null!;

    public long Locationid { get; set; }

    public string? AreaInvolvementCode { get; set; }

    public string? AreaInvolvementDescription { get; set; }
}
