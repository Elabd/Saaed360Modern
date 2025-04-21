using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PublicNotifier
{
    public long PublicNotifId { get; set; }

    public long ReportNotifierId { get; set; }

    public bool IsActive { get; set; }
}
