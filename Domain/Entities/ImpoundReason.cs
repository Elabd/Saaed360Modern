using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundReason
{
    public int Id { get; set; }

    public string ImpoundReason1 { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
