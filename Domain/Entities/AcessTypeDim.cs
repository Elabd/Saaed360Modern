using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AcessTypeDim
{
    public short Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<PageRole> PageRoles { get; set; } = new List<PageRole>();
}
