using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NationalityLanguageView
{
    public int NationalityId { get; set; }

    public string Language { get; set; } = null!;

    public string? Description { get; set; }
}
