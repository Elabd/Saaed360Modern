using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AgencyCategoryDimcodeView
{
    public string? AgencyCategoryDescription { get; set; }

    public string? AgencyCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
