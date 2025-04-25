using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UnderProcessConvertLog
{
    public long Id { get; set; }

    public long ReportId { get; set; }

    public string? Comment { get; set; }

    public DateTime CreationTime { get; set; }

    public long UserId { get; set; }
}
