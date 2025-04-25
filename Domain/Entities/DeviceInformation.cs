using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DeviceInformation
{
    public Guid DeviceInfoId { get; set; }

    public long UserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public string DeviceCode { get; set; } = null!;

    public string DeviceName { get; set; } = null!;

    public string Osversion { get; set; } = null!;

    public string CurrentSaaedversion { get; set; } = null!;

    public int DeviceType { get; set; }
}
