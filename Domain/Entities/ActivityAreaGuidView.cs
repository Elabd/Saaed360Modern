using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityAreaGuidView
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

    public Guid ActivityAreaGuid { get; set; }

    public string? ActivityAreaDescription { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? AreaInvolvementCode { get; set; }
}
