using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileRequestImage
{
    public long Id { get; set; }

    public long? ImageId { get; set; }

    public long? VehicleId { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsDocumentImage { get; set; }

    public virtual Image? Image { get; set; }

    public virtual MobileRequestVehicle? Vehicle { get; set; }
}
