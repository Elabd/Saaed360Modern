using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistProviderPerson
{
    public Guid ProviderId { get; set; }

    public long PersonId { get; set; }

    public virtual RoadAssistProvider Provider { get; set; } = null!;
}
