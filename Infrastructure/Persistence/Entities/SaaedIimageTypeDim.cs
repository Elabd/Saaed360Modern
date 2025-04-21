using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedIimageTypeDim
{
    public Guid SaaedIimageTypeId { get; set; }

    public string? SaaedIimageTypeCode { get; set; }

    public string? DescriptionEn { get; set; }

    public string? DescriptionAr { get; set; }

    public virtual ICollection<SaaedIprocessedImage> SaaedIprocessedImages { get; set; } = new List<SaaedIprocessedImage>();
}
