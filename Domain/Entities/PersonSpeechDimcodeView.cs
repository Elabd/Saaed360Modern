using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonSpeechDimcodeView
{
    public string? PersonSpeechDescription { get; set; }

    public string? PersonSpeechCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
