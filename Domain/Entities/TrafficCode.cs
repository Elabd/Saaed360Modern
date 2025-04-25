using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TrafficCode
{
    public long TrafficCodeId { get; set; }

    public string? Description { get; set; }

    public string? TrafficCode1 { get; set; }

    public string? LicenseNumber { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? OwnerName { get; set; }

    public string? DriverName { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }
}
