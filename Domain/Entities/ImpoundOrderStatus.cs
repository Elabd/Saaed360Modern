using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundOrderStatus
{
    public int Id { get; set; }

    public string ImpoundOrderStatus1 { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
