using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Lookup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public long Version { get; set; }

    public virtual ICollection<LookupDetail> LookupDetails { get; set; } = new List<LookupDetail>();
}
