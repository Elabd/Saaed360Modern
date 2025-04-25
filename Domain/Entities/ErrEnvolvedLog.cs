using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ErrEnvolvedLog
{
    public int TId { get; set; }

    public string? AccId { get; set; }

    public string? VecId { get; set; }

    public int? ErrCode { get; set; }

    public string? ErrDesc { get; set; }

    public string? ErrDescEn { get; set; }

    public DateTime? CrDate { get; set; }
}
