using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Contact
{
    public long ContactId { get; set; }

    public Guid ContactGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int ContactCategoryId { get; set; }

    public string? ContactName { get; set; }

    public string ContactInformation { get; set; } = null!;

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? ContactEmail { get; set; }

    public virtual ICollection<ActivityContact> ActivityContacts { get; set; } = new List<ActivityContact>();

    public virtual ContactCategoryDim ContactCategory { get; set; } = null!;

    public virtual ICollection<ContactComment> ContactComments { get; set; } = new List<ContactComment>();

    public virtual ICollection<LocationContact> LocationContacts { get; set; } = new List<LocationContact>();

    public virtual ICollection<OrganizationContact> OrganizationContacts { get; set; } = new List<OrganizationContact>();

    public virtual ICollection<PersonContact> PersonContacts { get; set; } = new List<PersonContact>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
