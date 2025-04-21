using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SearchDataTypeDimcodeView
{
    public string? SearchDataTypeDescription { get; set; }

    public string? SearchDataTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
