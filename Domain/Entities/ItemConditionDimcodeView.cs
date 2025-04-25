using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemConditionDimcodeView
{
    public string? ItemConditionDescription { get; set; }

    public string? ItemConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
