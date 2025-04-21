using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AccidentFeereminderMessage
{
    public long AccidentFeereminderMessageId { get; set; }

    public long NotificationMessageLogId { get; set; }

    public int FeesReminderTypeId { get; set; }

    public int? ReportId { get; set; }

    public int? VehicleDataId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual NotificationMessageLog NotificationMessageLog { get; set; } = null!;
}
