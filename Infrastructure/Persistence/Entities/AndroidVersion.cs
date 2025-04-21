using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AndroidVersion
{
    public long VersionNumber { get; set; }

    public string VersionUrl { get; set; } = null!;

    public bool IsActive { get; set; }
}
