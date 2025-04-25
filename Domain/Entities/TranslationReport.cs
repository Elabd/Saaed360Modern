using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TranslationReport
{
    public long TranslationId { get; set; }

    public int TranslationTableTypeId { get; set; }

    public int Code { get; set; }

    public string DescriptionAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual TranslationTablesType TranslationTableType { get; set; } = null!;
}
