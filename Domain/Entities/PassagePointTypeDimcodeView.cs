using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PassagePointTypeDimcodeView
{
    public string? PassagePointTypeDescription { get; set; }

    public string? PassagePointTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
