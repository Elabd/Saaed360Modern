using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetAreaToBeAddedAutoDispatch
{
    public long AreaId { get; set; }

    public string? AreaDescription { get; set; }
}
