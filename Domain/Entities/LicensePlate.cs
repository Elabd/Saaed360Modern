using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LicensePlate
{
    public long ItemId { get; set; }

    public int? LicensePlateListSourceId { get; set; }

    public int? LicensePlateListTypeId { get; set; }

    public DateTime? DateEntered { get; set; }

    public DateTime? DateOfTheft { get; set; }

    public string? Ncicnumber { get; set; }

    public DateTime? ExpireDate { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual LicensePlateListSourceDim? LicensePlateListSource { get; set; }

    public virtual LicensePlateListTypeDim? LicensePlateListType { get; set; }
}

