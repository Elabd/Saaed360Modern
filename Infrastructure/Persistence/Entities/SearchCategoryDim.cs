using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SearchCategoryDim
{
    public int SearchCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SearchParameterDim> SearchParameterDims { get; set; } = new List<SearchParameterDim>();

    public virtual ICollection<Search> Searches { get; set; } = new List<Search>();
}
