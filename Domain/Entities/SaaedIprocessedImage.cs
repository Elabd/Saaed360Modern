using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedIprocessedImage
{
    public Guid SaaedIprocessedImageId { get; set; }

    public long ImageId { get; set; }

    public int ReportId { get; set; }

    public Guid ImageTypeId { get; set; }

    public int? VehicleDataId { get; set; }

    public virtual Image Image { get; set; } = null!;

    public virtual SaaedIimageTypeDim ImageType { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual VehicleDatum? VehicleData { get; set; }
}
