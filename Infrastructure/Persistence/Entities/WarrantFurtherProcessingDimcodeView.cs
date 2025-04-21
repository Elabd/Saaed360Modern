using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class WarrantFurtherProcessingDimcodeView
{
    public string? WarrantFurtherProcessingDescription { get; set; }

    public string? WarrantFurtherProcessingCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
