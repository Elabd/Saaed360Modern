using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AreaAllowedMobileNumber
{
    public long Id { get; set; }

    public long AreaId { get; set; }

    public string MobileNumber { get; set; } = null!;

    public bool IsActive { get; set; }
}
