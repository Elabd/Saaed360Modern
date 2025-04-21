using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AreaGroupDim
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public int? MaxResponseTimeInSecs { get; set; }
}
