using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArticleTypeDim
{
    public int ArticleTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? CategoryDescription { get; set; }

    public string? CategoryCode { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Article> Articles { get; set; } = new List<Article>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
