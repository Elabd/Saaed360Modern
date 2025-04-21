using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationMatrix
{
    public long LocationMatrixId { get; set; }

    public long? EmiratesId { get; set; }

    public long? CityId { get; set; }

    public long? AreaId { get; set; }

    public long? SectorId { get; set; }

    public long? StreetId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Area? Area { get; set; }

    public virtual Area? City { get; set; }

    public virtual Area? Emirates { get; set; }

    public virtual Area? Sector { get; set; }

    public virtual Area? Street { get; set; }
}
