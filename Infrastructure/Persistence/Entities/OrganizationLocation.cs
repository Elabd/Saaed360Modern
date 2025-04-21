using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationLocation
{
    public long OrganizationLocationId { get; set; }

    public Guid OrganizationLocationGuid { get; set; }

    public string OrganizationLocationDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public long SourceId { get; set; }

    public int? LocationInvolvementId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual LocationInvolvementDim? LocationInvolvement { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
