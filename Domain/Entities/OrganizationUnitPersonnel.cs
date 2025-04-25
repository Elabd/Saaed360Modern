using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitPersonnel
{
    public long OrganizationUnitPersonnelId { get; set; }

    public Guid OrganizationUnitPersonnelGuid { get; set; }

    public string OrganizationUnitPersonnelDescription { get; set; } = null!;

    public long OrganizationUnitId { get; set; }

    public Guid OrganizationUnitGuid { get; set; }

    public long OrganzationPersonId { get; set; }

    public Guid OrganzationPersonGuid { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public long? SourceId { get; set; }

    public int? RowStatusId { get; set; }

    public virtual OrganizationUnit OrganizationUnit { get; set; } = null!;

    public virtual OrganizationPerson OrganzationPerson { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source? Source { get; set; }
}
