using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Search
{
    public long ActivityId { get; set; }

    public long SourceId { get; set; }

    public int? AuthorizationTypeId { get; set; }

    public int? SearchCategoryId { get; set; }

    public string? SearchXml { get; set; }

    public DateTime? SearchDateTime { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual AuthorizationTypeDim? AuthorizationType { get; set; }

    public virtual SearchCategoryDim? SearchCategory { get; set; }

    public virtual Source Source { get; set; } = null!;
}
