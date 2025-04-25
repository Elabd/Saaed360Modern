using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonHistoricalLocation
{
    public long Id { get; set; }

    public long PersonId { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime ActionDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Person Person { get; set; } = null!;
}
