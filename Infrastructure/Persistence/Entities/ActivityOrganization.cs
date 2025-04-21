using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityOrganization
{
    public long ActivityOrganizationId { get; set; }

    public Guid ActivityOrganizationGuid { get; set; }

    public string ActivityOrganizationDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long Organizationid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long SourceId { get; set; }

    public int OrganizationInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsOwner { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual OrganizationInvolvementDim OrganizationInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
