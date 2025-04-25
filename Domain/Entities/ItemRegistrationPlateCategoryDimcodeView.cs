using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistrationPlateCategoryDimcodeView
{
    public string? ItemRegistrationPlateCategoryDescription { get; set; }

    public string? ItemRegistrationPlateCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

