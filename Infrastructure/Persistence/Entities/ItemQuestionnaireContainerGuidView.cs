using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemQuestionnaireContainerGuidView
{
    public Guid ItemDocumentGuid { get; set; }

    public string ItemDocumentDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public Guid DocumentGuid { get; set; }

    public string? DocumentInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
