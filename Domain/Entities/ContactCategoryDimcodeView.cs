using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ContactCategoryDimcodeView
{
    public string? ContactCategoryDescription { get; set; }

    public string? ContactCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
