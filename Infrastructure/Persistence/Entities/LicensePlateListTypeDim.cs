using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LicensePlateListTypeDim
{
    public int LicensePlateListTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<LicensePlate> LicensePlates { get; set; } = new List<LicensePlate>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

