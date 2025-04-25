using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionStatusDim
{
    public int StatusId { get; set; }

    public string ArabicDescription { get; set; } = null!;

    public string EnglishDescription { get; set; } = null!;
}
