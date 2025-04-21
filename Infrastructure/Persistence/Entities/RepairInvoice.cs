using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairInvoice
{
    public long Id { get; set; }

    public long RepairQuoteId { get; set; }

    public long UploadByPersonId { get; set; }

    public DateTime UploadDate { get; set; }

    public string FilePath { get; set; } = null!;

    public long LastModifiedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual RepairQuote RepairQuote { get; set; } = null!;

    public virtual Person UploadByPerson { get; set; } = null!;
}
