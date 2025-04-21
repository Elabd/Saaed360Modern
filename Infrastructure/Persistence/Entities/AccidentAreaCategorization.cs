using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AccidentAreaCategorization
{
    public int AccidentAreaCategorizationId { get; set; }

    public long? EmirateId { get; set; }

    public long CityId { get; set; }

    public bool IsHighAccidentArea { get; set; }

    public virtual CityDim City { get; set; } = null!;

    public virtual EmirateDim? Emirate { get; set; }
}
