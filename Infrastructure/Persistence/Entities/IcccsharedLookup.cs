using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccsharedLookup
{
    public int Id { get; set; }

    public int LookupTypeId { get; set; }

    public long Icccvalue { get; set; }

    public long SaaedValue { get; set; }

    public long? AreaId { get; set; }

    public int Icccdb { get; set; }

    public string? Icccdescription { get; set; }

    public string? SaaedDescription { get; set; }

    public virtual IcccsharedLookupType LookupType { get; set; } = null!;
}
