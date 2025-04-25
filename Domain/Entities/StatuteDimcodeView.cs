using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class StatuteDimcodeView
{
    public string StatuteCode { get; set; } = null!;

    public string? StatuteDescription { get; set; }

    public string? StatuteStatuteDescription { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
