using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OffenseIncidentAssociation
{
    public long OffenseIncidentAssociationId { get; set; }

    public Guid OffenseIncidentAssociationGuid { get; set; }

    public string OffenseIncidentAssociationDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long OffenseId { get; set; }

    public Guid OffenseGuid { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Offense Offense { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
