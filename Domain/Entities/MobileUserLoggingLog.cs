using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileUserLoggingLog
{
    public long MobileUserLogId { get; set; }

    public long MobileUserId { get; set; }

    public DateTime LogDate { get; set; }

    public int LogTypeId { get; set; }
}
