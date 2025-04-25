using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImageFormatDimcodeView
{
    public string? ImageFormatDescription { get; set; }

    public string? ImageFormatCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
