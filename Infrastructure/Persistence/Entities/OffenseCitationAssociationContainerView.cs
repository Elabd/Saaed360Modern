using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OffenseCitationAssociationContainerView
{
    public long OffenseCitationAssociationId { get; set; }

    public string OffenseCitationAssociationDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long OffenseId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
