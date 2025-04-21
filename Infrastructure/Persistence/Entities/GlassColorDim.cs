using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GlassColorDim
{
    public int GlassColorId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();
}
