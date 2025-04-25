using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SearchDataTypeDimcodeView
{
    public string? SearchDataTypeDescription { get; set; }

    public string? SearchDataTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
