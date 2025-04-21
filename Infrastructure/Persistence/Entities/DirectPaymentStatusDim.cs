using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DirectPaymentStatusDim
{
    public int Id { get; set; }

    public string? Name { get; set; }
}
