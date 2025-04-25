using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundPriority
{
    public int Id { get; set; }

    public string ImpoundPriority1 { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
