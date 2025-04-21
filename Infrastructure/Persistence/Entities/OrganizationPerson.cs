using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationPerson
{
    public long OrganizationPersonId { get; set; }

    public Guid OrganizationPersonGuid { get; set; }

    public string OrganizationPersonDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public int PersonInvolvementId { get; set; }

    public long SourceId { get; set; }

    public int? OrganizationPersonnelCategoryId { get; set; }

    public int? OrganizationPersonnelRoleId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public DateTime? FromDateTimeStamp { get; set; }

    public DateTime? ToDateTimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<CourtOrder> CourtOrders { get; set; } = new List<CourtOrder>();

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual OrganizationPersonnelCategoryDim? OrganizationPersonnelCategory { get; set; }

    public virtual OrganizationPersonnelRoleDim? OrganizationPersonnelRole { get; set; }

    public virtual ICollection<OrganizationUnitPersonnel> OrganizationUnitPersonnel { get; set; } = new List<OrganizationUnitPersonnel>();

    public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();

    public virtual Person Person { get; set; } = null!;

    public virtual PersonInvolvementDim PersonInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
