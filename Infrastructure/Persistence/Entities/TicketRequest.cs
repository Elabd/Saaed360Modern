using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TicketRequest
{
    public long TicketRequestId { get; set; }

    public string ReportNumber { get; set; } = null!;

    public long CreatedById { get; set; }

    public DateTime CreationTime { get; set; }

    public virtual ICollection<TicketRequestInfo> TicketRequestInfos { get; set; } = new List<TicketRequestInfo>();
}
