using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Article
{
    public long ItemId { get; set; }

    public int ArticleTypeId { get; set; }

    public int ArticleCategoryId { get; set; }

    public virtual ArticleCategoryDim ArticleCategory { get; set; } = null!;

    public virtual ArticleTypeDim ArticleType { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;
}
