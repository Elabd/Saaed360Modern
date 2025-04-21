using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetAreaCenter
{
    public long AreaId { get; set; }

    public double? Lat { get; set; }

    public double? Long { get; set; }
}
