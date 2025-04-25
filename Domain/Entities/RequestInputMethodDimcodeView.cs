using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestInputMethodDimcodeView
{
    public string? RequestInputMethodDescription { get; set; }

    public string? RequestInputMethodCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
