using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Saaed360VersionInfoDim
{
    public int Id { get; set; }

    public int VersionNumber { get; set; }

    public string VersionName { get; set; } = null!;

    public string VersionPath { get; set; } = null!;

    public DateTime VersionDate { get; set; }
}
