using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SentenceGroupingDimcodeView
{
    public string? SentenceGroupingDescription { get; set; }

    public string? SentenceGroupingCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
