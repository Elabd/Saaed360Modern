using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityEnforcementOfficialContainerGuidView
{
    public Guid ActivityPersonGuid { get; set; }

    public string ActivityPersonDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? SourceName { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
