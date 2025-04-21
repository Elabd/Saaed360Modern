using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetDetectLocationAreaDetail
{
    public long Id { get; set; }

    public long AreaId { get; set; }

    public string? Description { get; set; }
}
