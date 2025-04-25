using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DamagedPartSeverityDim
{
    public int DamagedPartSeverityId { get; set; }

    public string? Description { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Code { get; set; }

    public bool? Show { get; set; }

    public virtual ICollection<EsRepairPermissionDamagedPart> EsRepairPermissionDamagedParts { get; set; } = new List<EsRepairPermissionDamagedPart>();

    public virtual ICollection<VehicleDamagedPart> VehicleDamagedParts { get; set; } = new List<VehicleDamagedPart>();
}
