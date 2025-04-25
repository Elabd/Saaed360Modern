using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RepairImage
{
    public long Id { get; set; }

    public long RepairQuoteId { get; set; }

    public int Type { get; set; }

    public string DisplayName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public long UploadByPersonId { get; set; }

    public DateTime UploadDate { get; set; }

    public long LastModifiedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Person LastModifiedByNavigation { get; set; } = null!;

    public virtual RepairQuote RepairQuote { get; set; } = null!;

    public virtual Person UploadByPerson { get; set; } = null!;
}
