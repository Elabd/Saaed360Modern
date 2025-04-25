using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImageCategoryDimcodeView
{
    public string? ImageCategoryDescription { get; set; }

    public string? ImageCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
