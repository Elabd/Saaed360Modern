using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonRaceDimcodeView
{
    public string? PersonRaceDescription { get; set; }

    public string? PersonRaceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
