using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonHairColorDim
{
    public int PersonHairColorId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonFacialHairDim> PersonFacialHairDims { get; set; } = new List<PersonFacialHairDim>();

    public virtual ICollection<PersonVitalStatistic> PersonVitalStatistics { get; set; } = new List<PersonVitalStatistic>();

    public virtual ICollection<PhysicalAppearanceHistory> PhysicalAppearanceHistories { get; set; } = new List<PhysicalAppearanceHistory>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
