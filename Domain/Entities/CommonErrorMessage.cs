using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CommonErrorMessage
{
    public int Id { get; set; }

    public string? ErrorMessage { get; set; }

    public string? ErrorDescription { get; set; }
}
