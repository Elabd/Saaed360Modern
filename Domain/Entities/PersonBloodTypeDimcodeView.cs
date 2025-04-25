using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonBloodTypeDimcodeView
{
    public string? PersonBloodTypeDescription { get; set; }

    public string? PersonBloodTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
