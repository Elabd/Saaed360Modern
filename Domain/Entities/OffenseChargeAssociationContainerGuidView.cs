using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseChargeAssociationContainerGuidView
{
    public Guid OffenseChargeAssociationGuid { get; set; }

    public string OffenseChargeAssociationDescription { get; set; } = null!;

    public Guid ChargeGuid { get; set; }

    public Guid OffenseGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
