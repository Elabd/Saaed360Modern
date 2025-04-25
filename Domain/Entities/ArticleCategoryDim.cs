using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArticleCategoryDim
{
    public int ArticleCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
