using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SearchResponseStatusDim
{
    public int ResponseStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SearchResponse> SearchResponses { get; set; } = new List<SearchResponse>();
}
