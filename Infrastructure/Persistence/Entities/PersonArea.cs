using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonArea
{
    public long PersonAreaId { get; set; }

    public long? PersonId { get; set; }

    public long? AreaId { get; set; }

    public virtual Area? Area { get; set; }

    public virtual Person? Person { get; set; }
}
