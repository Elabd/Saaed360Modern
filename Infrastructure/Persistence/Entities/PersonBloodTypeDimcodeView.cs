using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonBloodTypeDimcodeView
{
    public string? PersonBloodTypeDescription { get; set; }

    public string? PersonBloodTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
