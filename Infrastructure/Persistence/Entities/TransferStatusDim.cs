using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TransferStatusDim
{
    public int TransferStatusId { get; set; }

    public string Description { get; set; } = null!;

    public string? DescriptionAr { get; set; }
}
