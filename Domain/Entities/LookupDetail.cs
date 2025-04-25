using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LookupDetail
{
    public int Id { get; set; }

    public int? LookupId { get; set; }

    public string Name { get; set; } = null!;

    public int Code { get; set; }

    public string? NameAr { get; set; }

    public virtual Lookup? Lookup { get; set; }
}
