using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TranslationTablesType
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public virtual ICollection<TranslationReport> TranslationReports { get; set; } = new List<TranslationReport>();
}
