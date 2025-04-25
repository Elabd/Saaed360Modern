using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VersionInfoDim
{
    public int Id { get; set; }

    public int VersionNumber { get; set; }

    public string VersionPath { get; set; } = null!;

    public DateTime VersionDate { get; set; }
}
