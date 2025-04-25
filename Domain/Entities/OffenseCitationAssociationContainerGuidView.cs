using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseCitationAssociationContainerGuidView
{
    public Guid OffenseCitationAssociationGuid { get; set; }

    public string OffenseCitationAssociationDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid OffenseGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
