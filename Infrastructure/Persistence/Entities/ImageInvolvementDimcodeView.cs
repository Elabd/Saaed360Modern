using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImageInvolvementDimcodeView
{
    public string? ImageInvolvementDescription { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
