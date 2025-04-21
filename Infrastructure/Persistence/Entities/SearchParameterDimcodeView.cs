using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SearchParameterDimcodeView
{
    public string? SearchParameterDescription { get; set; }

    public string? SearchParameterCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
