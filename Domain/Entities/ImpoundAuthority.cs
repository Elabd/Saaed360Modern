using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundAuthority
{
    public int Id { get; set; }

    public string AuthorityDescription { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
