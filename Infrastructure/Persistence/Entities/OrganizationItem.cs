using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationItem
{
    public long OrganizationItemId { get; set; }

    public Guid OrganizationItemGuid { get; set; }

    public string OrganizationItemDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

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

    public long? CurrentStatusId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual OrganizationItemStatusDim? CurrentStatus { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ItemInvolvementDim ItemInvolvement { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
