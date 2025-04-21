using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonInvolvementDimcodeView
{
    public string? PersonInvolvementDescription { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
