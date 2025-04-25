using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TransferStatusDim
{
    public int TransferStatusId { get; set; }

    public string Description { get; set; } = null!;

    public string? DescriptionAr { get; set; }
}
