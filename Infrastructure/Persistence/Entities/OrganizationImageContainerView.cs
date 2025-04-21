using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationImageContainerView
{
    public long OrganizationImageId { get; set; }

    public string OrganizationImageDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public long ImageId { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public string? ImageInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
