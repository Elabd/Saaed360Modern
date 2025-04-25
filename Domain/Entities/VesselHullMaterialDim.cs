using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VesselHullMaterialDim
{
    public int VesselHullMaterialId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Vessel> Vessels { get; set; } = new List<Vessel>();
}
