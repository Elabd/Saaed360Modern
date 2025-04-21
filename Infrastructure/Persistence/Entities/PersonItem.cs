using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonItem
{
    public long PersonItemId { get; set; }

    public Guid PersonItemGuid { get; set; }

    public string PersonItemDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public int ItemInvolvementId { get; set; }

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

    public virtual ItemInvolvementDim ItemInvolvement { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
