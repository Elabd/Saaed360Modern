using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistRatingNotificationLog
{
    public Guid NotificationLogId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid RequestId { get; set; }

    public virtual RoadAssistRequest Request { get; set; } = null!;
}
