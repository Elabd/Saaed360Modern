using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemRegistrationPlateCategoryDimcodeView
{
    public string? ItemRegistrationPlateCategoryDescription { get; set; }

    public string? ItemRegistrationPlateCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

