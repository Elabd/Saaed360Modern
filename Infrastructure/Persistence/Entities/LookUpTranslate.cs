using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LookUpTranslate
{
    public long TranslateLookUpId { get; set; }

    public int LookUpTypeId { get; set; }

    public int LookUpIdValue { get; set; }

    public string LookUpArabicDesc { get; set; } = null!;

    public string LookUpEnglishDesc { get; set; } = null!;
}
