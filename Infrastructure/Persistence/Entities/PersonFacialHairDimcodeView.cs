using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonFacialHairDimcodeView
{
    public string? PersonFacialHairDescription { get; set; }

    public string? PersonFacialHairCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
