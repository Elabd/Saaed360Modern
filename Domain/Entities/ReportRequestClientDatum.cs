using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportRequestClientDatum
{
    public long ClientId { get; set; }

    public string? ClientName { get; set; }

    public string? ClientPhone { get; set; }

    public string? ClientEmail { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? RequestId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ReportRequest? Request { get; set; }
}
