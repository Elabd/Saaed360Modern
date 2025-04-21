using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SupportTableSpsFunctionsAndView
{
    public string Table { get; set; } = null!;

    public string ProcName { get; set; } = null!;

    public string SqlCode { get; set; } = null!;

    public string? Error { get; set; }

    public DateTime? ExecutedDateTimeStamp { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
