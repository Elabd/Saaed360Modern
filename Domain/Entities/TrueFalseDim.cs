using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TrueFalseDim
{
    public int TrueFalseId { get; set; }

    public bool? TrueFalseNumeric { get; set; }

    public string? YesNo { get; set; }

    public string? TrueFalse { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
