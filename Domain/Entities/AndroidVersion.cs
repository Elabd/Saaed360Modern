using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AndroidVersion
{
    public long VersionNumber { get; set; }

    public string VersionUrl { get; set; } = null!;

    public bool IsActive { get; set; }
}
