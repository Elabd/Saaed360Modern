using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImpoundOrderVehicleDispatch
{
    public long Id { get; set; }

    public long ImpoundOrderVehicleId { get; set; }

    public long DispatchedVehicleId { get; set; }

    public long DispatchedPersonId { get; set; }

    public long CreatedBy { get; set; }

    public DateTime DateCreated { get; set; }

    public bool IsDeteled { get; set; }
}
