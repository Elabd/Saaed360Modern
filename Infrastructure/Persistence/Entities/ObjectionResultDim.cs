using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ObjectionResultDim
{
    public int ObjectionResultId { get; set; }

    public string ResultName { get; set; } = null!;

    public string ResultNameEnglish { get; set; } = null!;
}
