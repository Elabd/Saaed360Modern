using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SmartDispatchingConfiguration
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Comment { get; set; }
}
