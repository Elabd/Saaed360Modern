using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationImageContainerGuidView
{
    public Guid OrganizationImageGuid { get; set; }

    public string OrganizationImageDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public Guid ImageGuid { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
