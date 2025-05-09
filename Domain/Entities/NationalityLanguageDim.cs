using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NationalityLanguageDim
{
    public long NationalityLangId { get; set; }

    public int NationalityId { get; set; }

    public string Language { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
