using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SupportExceptionDimtable
{
    public string SpecialTableName { get; set; } = null!;

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
