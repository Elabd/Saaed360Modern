using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnit
{
    public long OrganizationUnitId { get; set; }

    public Guid OrganizationUnitGuid { get; set; }

    public string OrganizationUnitDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long SourceId { get; set; }

    public long? PrimaryPersonId { get; set; }

    public Guid? PrimaryPersonGuid { get; set; }

    public int? OrganizationUnitCategoryId { get; set; }

    public int? OrganizationStatusId { get; set; }

    public string? UnitName { get; set; }

    public string? OriginalIdent { get; set; }

    public string? UnitAbbreviation { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual OrganizationStatusDim? OrganizationStatus { get; set; }

    public virtual OrganizationUnitCategoryDim? OrganizationUnitCategory { get; set; }

    public virtual ICollection<OrganizationUnitLog> OrganizationUnitLogs { get; set; } = new List<OrganizationUnitLog>();

    public virtual ICollection<OrganizationUnitPersonnel> OrganizationUnitPersonnel { get; set; } = new List<OrganizationUnitPersonnel>();

    public virtual OrganizationPerson? PrimaryPerson { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
