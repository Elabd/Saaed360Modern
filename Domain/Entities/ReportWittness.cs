using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportWittness
{
    public int ReportWittnessId { get; set; }

    public int? WittnessId { get; set; }

    public int? ReportId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Report? Report { get; set; }

    public virtual Wittness? Wittness { get; set; }
}
