using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IntoxicationIntoxicantCategoryDimcodeView
{
    public string? IntoxicationIntoxicantCategoryDescription { get; set; }

    public string? IntoxicationIntoxicantCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
