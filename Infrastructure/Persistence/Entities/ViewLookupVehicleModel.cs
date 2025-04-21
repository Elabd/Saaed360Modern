using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewLookupVehicleModel
{
    public int Id { get; set; }

    public string? Arabic { get; set; }

    public string? English { get; set; }

    public string? Original { get; set; }

    public int? VehicleBrandId { get; set; }
}
