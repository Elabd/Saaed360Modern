using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationArea
{
    public long LocationAreaId { get; set; }

    public Guid LocationAreaGuid { get; set; }

    public string LocationAreaDescription { get; set; } = null!;

    public long Locationid { get; set; }

    public Guid LocationGuid { get; set; }

    public int AreaInvolvementId { get; set; }

    public long SourceId { get; set; }

    public long AreaId { get; set; }

    public Guid AreaGuid { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public DateTime? FromDateTimeStamp { get; set; }

    public DateTime? ToDateTimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual AreaInvolvementDim AreaInvolvement { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
