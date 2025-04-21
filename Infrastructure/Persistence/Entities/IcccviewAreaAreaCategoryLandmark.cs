using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewAreaAreaCategoryLandmark
{
    public long AreaId { get; set; }

    public long ActivityId { get; set; }

    public string? Description { get; set; }
}
