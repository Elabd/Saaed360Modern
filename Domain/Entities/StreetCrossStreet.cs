using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class StreetCrossStreet
{
    public long Id { get; set; }

    public long StreetId { get; set; }

    public long CrossStreetId { get; set; }

    public virtual CrossStreetDim CrossStreet { get; set; } = null!;

    public virtual StreetDim Street { get; set; } = null!;
}
