using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OwnerDatum
{
    public int OwnerDataId { get; set; }

    public int? VehicleDataId { get; set; }

    public string? TrafficCode { get; set; }

    public string? Name { get; set; }

    public int? NationalityId { get; set; }

    public string? Address { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual NationalityDim? Nationality { get; set; }

    public virtual VehicleDatum? VehicleData { get; set; }
}
