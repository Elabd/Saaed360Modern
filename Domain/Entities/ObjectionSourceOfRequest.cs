using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionSourceOfRequest
{
    public int SourceRequestId { get; set; }

    public string SourceName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
