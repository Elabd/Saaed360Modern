using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportImage
{
    public int ReportImageId { get; set; }

    public long ImageId { get; set; }

    public int ReportId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? VehicleDataId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Image Image { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual VehicleDatum? VehicleData { get; set; }
}
