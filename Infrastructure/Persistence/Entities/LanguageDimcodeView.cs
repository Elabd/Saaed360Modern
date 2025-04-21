using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LanguageDimcodeView
{
    public string? LanguageDescription { get; set; }

    public string? LanguageCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
