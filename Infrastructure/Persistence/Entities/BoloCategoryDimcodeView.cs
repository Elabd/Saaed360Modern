using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BoloCategoryDimcodeView
{
    public string? BoloCategoryDescription { get; set; }

    public string? BoloCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
