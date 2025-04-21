using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportNotifier
{
    public int ReportNotifierId { get; set; }

    public int NotifierId { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }

    public int? NotifierType { get; set; }

    public bool? IsActive { get; set; }

    public string? TrafficCode { get; set; }
}
