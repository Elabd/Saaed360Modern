using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GetAreaToBeAddedDetectLocation
{
    public long AreaId { get; set; }

    public string? AreaDescription { get; set; }
}
