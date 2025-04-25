using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SupportSupportExceptionDimtableDescriptionCodeColumnDetail
{
    public string Table { get; set; } = null!;

    public string ExpectedColumn { get; set; } = null!;

    public string OriginalColumn { get; set; } = null!;

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
