using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseIncidentAssociationContainerView
{
    public long OffenseIncidentAssociationId { get; set; }

    public string OffenseIncidentAssociationDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long OffenseId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
