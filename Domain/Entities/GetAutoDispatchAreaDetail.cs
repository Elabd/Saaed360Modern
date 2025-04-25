using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GetAutoDispatchAreaDetail
{
    public long Id { get; set; }

    public long AreaId { get; set; }

    public string? Description { get; set; }
}
