using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedCustomExceptionLog
{
    public long Id { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? CreatedTime { get; set; }
}
