using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonEyeColorDim
{
    public int PersonEyeColorId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Nicic { get; set; }

    public string? Niem1 { get; set; }

    public string? Niem2 { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonPhysicalDetail> PersonPhysicalDetails { get; set; } = new List<PersonPhysicalDetail>();

    public virtual ICollection<PhysicalAppearanceHistory> PhysicalAppearanceHistoryPersonLeftEyeColors { get; set; } = new List<PhysicalAppearanceHistory>();

    public virtual ICollection<PhysicalAppearanceHistory> PhysicalAppearanceHistoryPersonRightEyeColors { get; set; } = new List<PhysicalAppearanceHistory>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
