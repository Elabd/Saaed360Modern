using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetAreaToBeAddedDetectLocation
{
    public long AreaId { get; set; }

    public string? AreaDescription { get; set; }
}
