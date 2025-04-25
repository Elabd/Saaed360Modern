using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SmartDispatchingEmirateConfiguration
{
    public int Id { get; set; }

    public long EmirateId { get; set; }

    public bool IsEnabled { get; set; }

    public virtual EmirateDim Emirate { get; set; } = null!;
}
