using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArcproActionLog
{
    public long Id { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreatedbyUserId { get; set; }

    public int? ReportId { get; set; }

    public int? ArcproActionLogTypeId { get; set; }

    public virtual ArcproActionLogTypeDim? ArcproActionLogType { get; set; }
}
