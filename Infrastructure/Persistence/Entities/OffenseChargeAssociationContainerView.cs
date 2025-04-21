using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OffenseChargeAssociationContainerView
{
    public long OffenseChargeAssociationId { get; set; }

    public string OffenseChargeAssociationDescription { get; set; } = null!;

    public long ChargeId { get; set; }

    public long OffenseId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
