using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemLocation
{
    public long ItemLocationId { get; set; }

    public Guid ItemLocationGuid { get; set; }

    public string ItemLocationDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public int LocationInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public DateTime? FromDateTimeStamp { get; set; }

    public DateTime? ToDateTimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual LocationInvolvementDim LocationInvolvement { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
