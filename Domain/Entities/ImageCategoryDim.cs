using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImageCategoryDim
{
    public int ImageCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
