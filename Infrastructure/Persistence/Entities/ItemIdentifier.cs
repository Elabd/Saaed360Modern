using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemIdentifier
{
    public long ItemIdentifierId { get; set; }

    public Guid ItemIdentifierGuid { get; set; }

    public string ItemIdentifierDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public long SourceId { get; set; }

    public int? ItemIdentifierLocationId { get; set; }

    public int? ItemIdentifierDistinctiveMarkingId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ItemIdentifierDistinctiveMarkingDim? ItemIdentifierDistinctiveMarking { get; set; }

    public virtual ItemIdentifierLocationDim? ItemIdentifierLocation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
