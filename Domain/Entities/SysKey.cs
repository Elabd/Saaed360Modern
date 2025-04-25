using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SysKey
{
    public long Id { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }
}
