using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortTypeDim
{
    public int EscortTypeId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public virtual ICollection<Escort> Escorts { get; set; } = new List<Escort>();
}
