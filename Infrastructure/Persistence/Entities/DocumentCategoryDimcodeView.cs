using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DocumentCategoryDimcodeView
{
    public string? DocumentCategoryDescription { get; set; }

    public string? DocumentCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
