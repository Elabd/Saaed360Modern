using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PublicNotifier
{
    public long PublicNotifId { get; set; }

    public long ReportNotifierId { get; set; }

    public bool IsActive { get; set; }
}
