using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityQuestionnaireContainerGuidView
{
    public Guid ActivityDocumentGuid { get; set; }

    public string ActivityDocumentDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public string? SourceName { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
