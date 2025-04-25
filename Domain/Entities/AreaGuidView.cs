using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AreaGuidView
{
    public Guid AreaGuid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? AreaCategoryCode { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
