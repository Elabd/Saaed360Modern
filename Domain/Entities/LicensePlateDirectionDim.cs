using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LicensePlateDirectionDim
{
    public int LicensePlateDirectionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<LicensePlateLocation> LicensePlateLocations { get; set; } = new List<LicensePlateLocation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

