using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SearchResponse
{
    public long ActivityId { get; set; }

    public long SourceId { get; set; }

    public int ResponseStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual SearchResponseStatusDim ResponseStatus { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
