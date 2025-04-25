using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonCategoryDimcodeView
{
    public string? PersonCategoryDescription { get; set; }

    public string? PersonCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
