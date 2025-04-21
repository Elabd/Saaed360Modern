using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ContactInvolvementDim
{
    public int ContactInvolvementId { get; set; }

    public string Description { get; set; } = null!;

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ActivityContact> ActivityContacts { get; set; } = new List<ActivityContact>();

    public virtual ICollection<LocationContact> LocationContacts { get; set; } = new List<LocationContact>();

    public virtual ICollection<OrganizationContact> OrganizationContacts { get; set; } = new List<OrganizationContact>();

    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
