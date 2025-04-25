using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ClassificationDimcodeView
{
    public string? ClassificationDescription { get; set; }

    public string? ClassificationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

