using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationQuestionnaireContainerGuidView
{
    public Guid OrganizationDocumentGuid { get; set; }

    public string OrganizationDocumentDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
