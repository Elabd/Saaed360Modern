using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewLookupDamagedPart
{
    public int Id { get; set; }

    public string? Arabic { get; set; }

    public string? English { get; set; }

    public string Original { get; set; } = null!;
}
