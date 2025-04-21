using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccsharedLookupType
{
    public int Id { get; set; }

    public string LookupType { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<IcccsharedLookup> IcccsharedLookups { get; set; } = new List<IcccsharedLookup>();
}
