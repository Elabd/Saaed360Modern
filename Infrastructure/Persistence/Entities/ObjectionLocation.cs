using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ObjectionLocation
{
    public long ObjectionLocationId { get; set; }

    public long? ObjectionId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Objection? Objection { get; set; }
}
