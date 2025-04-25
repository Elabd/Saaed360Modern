using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GetAreaToBeAddedAutoDispatch
{
    public long AreaId { get; set; }

    public string? AreaDescription { get; set; }
}
