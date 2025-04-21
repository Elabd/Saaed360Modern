using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonTransportedByDimcodeView
{
    public string? PersonTransportedByDescription { get; set; }

    public string? PersonTransportedByCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
