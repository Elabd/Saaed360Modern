using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityImage
{
    public long ActivityImageId { get; set; }

    public Guid ActivityImageGuid { get; set; }

    public string ActivityImageDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long ImageId { get; set; }

    public Guid ImageGuid { get; set; }

    public long SourceId { get; set; }

    public int ImageInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Image Image { get; set; } = null!;

    public virtual ImageInvolvementDim ImageInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
