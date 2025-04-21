using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportDamagedProperty
{
    public int ReportDamagedPropertyId { get; set; }

    public int? DamagedPropertyId { get; set; }

    public int? ReportId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual DamagedProperty? DamagedProperty { get; set; }

    public virtual Report? Report { get; set; }
}
