using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemImage
{
    public long ItemImageId { get; set; }

    public Guid ItemImageGuid { get; set; }

    public string ItemImageDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public long ImageId { get; set; }

    public Guid ImageGuid { get; set; }

    public int ImageInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Image Image { get; set; } = null!;

    public virtual ImageInvolvementDim ImageInvolvement { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
