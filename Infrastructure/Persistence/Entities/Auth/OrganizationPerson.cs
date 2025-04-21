using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities.Auth;

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
}
