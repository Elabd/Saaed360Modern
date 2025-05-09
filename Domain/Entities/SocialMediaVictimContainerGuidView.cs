using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaVictimContainerGuidView
{
    public Guid SocialMediaPersonGuid { get; set; }

    public string SocialMediaPersonDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? SourceName { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
