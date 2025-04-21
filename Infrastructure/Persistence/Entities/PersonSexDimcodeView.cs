using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonSexDimcodeView
{
    public string? PersonSexDescription { get; set; }

    public string? PersonSexCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
