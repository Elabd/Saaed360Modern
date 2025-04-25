using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MilitaryServiceTypeDimcodeView
{
    public string? MilitaryServiceTypeDescription { get; set; }

    public string? MilitaryServiceTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

