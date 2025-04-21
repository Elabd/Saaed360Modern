using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImageCategoryDimcodeView
{
    public string? ImageCategoryDescription { get; set; }

    public string? ImageCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
