using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DocumentFormatDimcodeView
{
    public string? DocumentFormatDescription { get; set; }

    public string? DocumentFormatCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
