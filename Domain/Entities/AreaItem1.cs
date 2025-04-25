using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AreaItem1
{
    public long Id { get; set; }

    public long? ItemId { get; set; }

    public long? AreaId { get; set; }

    public virtual Area? Area { get; set; }

    public virtual Item? Item { get; set; }
}
