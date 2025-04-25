using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaCategoryDimcodeView
{
    public string? SocialMediaCategoryDescription { get; set; }

    public string? SocialMediaCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
