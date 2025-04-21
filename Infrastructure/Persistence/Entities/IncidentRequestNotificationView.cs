using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentRequestNotificationView
{
    public string? Code { get; set; }

    public long RequestId { get; set; }

    public long? AreaId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? PersonName { get; set; }

    public string? Name { get; set; }

    public int StatusId { get; set; }
}
