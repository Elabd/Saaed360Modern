using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonNameCategoryDimcodeView
{
    public string? PersonNameCategoryDescription { get; set; }

    public string? PersonNameCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
