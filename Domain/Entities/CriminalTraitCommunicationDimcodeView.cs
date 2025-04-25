using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitCommunicationDimcodeView
{
    public string? CriminalTraitCommunicationDescription { get; set; }

    public string? CriminalTraitCommunicationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
