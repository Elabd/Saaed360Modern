using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DirectPaymentSourceDim
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
