using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsMissionsType
{
    public long EventsMissionsTypesId { get; set; }

    public long EventsMissionId { get; set; }

    public int EventsMissionTypeDimId { get; set; }

    public bool? IsDeteted { get; set; }

    public virtual EventsMission EventsMission { get; set; } = null!;

    public virtual EventsMissionTypeDim EventsMissionTypeDim { get; set; } = null!;
}
