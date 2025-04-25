using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DriverDataConfiscationLog
{
    public long DriverDataConfiscationLogId { get; set; }

    public int? DriverDataId { get; set; }

    public int? ConfiscationStatusId { get; set; }

    public string? Comment { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDatetime { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDatetime { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ConfiscationStatusDim? ConfiscationStatus { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual DriverDatum? DriverData { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }
}
