using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaeedOlapreportsType
{
    public int Pkid { get; set; }

    public string ReportCategory { get; set; } = null!;

    public virtual ICollection<SaeedOlapreportsTable> SaeedOlapreportsTables { get; set; } = new List<SaeedOlapreportsTable>();
}
