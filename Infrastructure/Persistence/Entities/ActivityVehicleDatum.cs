using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityVehicleDatum
{
    public int ActivityVehicleDataId { get; set; }

    public long ActivityId { get; set; }

    public int VehicleDataId { get; set; }

    public DateTime? CreationDate { get; set; }

    public byte[]? TimeStamp { get; set; }
}
