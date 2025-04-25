using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DeliveryCompanyDim
{
    public long DeliveryCompanyId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();
}
