using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonSkinToneDim
{
    public int PersonSkinToneId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonVitalStatistic> PersonVitalStatistics { get; set; } = new List<PersonVitalStatistic>();

    public virtual ICollection<PhysicalAppearanceHistory> PhysicalAppearanceHistories { get; set; } = new List<PhysicalAppearanceHistory>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
