using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SysKey
{
    public long Id { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }
}
