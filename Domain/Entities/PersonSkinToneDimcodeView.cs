using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonSkinToneDimcodeView
{
    public string? PersonSkinToneDescription { get; set; }

    public string? PersonSkinToneCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
