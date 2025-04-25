using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertSenderDim
{
    public int AlertSenderId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
