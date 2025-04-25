using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Parameter
{
    public long Id { get; set; }

    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public string? Description { get; set; }
}
