using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseChargeAssociation
{
    public long OffenseChargeAssociationId { get; set; }

    public Guid OffenseChargeAssociationGuid { get; set; }

    public string OffenseChargeAssociationDescription { get; set; } = null!;

    public long ChargeId { get; set; }

    public Guid ChargeGuid { get; set; }

    public long OffenseId { get; set; }

    public Guid OffenseGuid { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Charge Charge { get; set; } = null!;

    public virtual Offense Offense { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
