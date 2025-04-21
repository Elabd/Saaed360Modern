using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ContactCategoryDim
{
    public int ContactCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
