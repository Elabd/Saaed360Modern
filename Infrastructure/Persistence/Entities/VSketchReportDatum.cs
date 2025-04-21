using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VSketchReportDatum
{
    public long ActivityId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public string? ContactName { get; set; }

    public string? ContactInformation { get; set; }

    public string? AreaDescription { get; set; }

    public string? Dispatcher { get; set; }

    public string? CallTaker { get; set; }

    public string? TrafficExpert { get; set; }

    public string? ActivityDescription { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public DateTime? CustomerDateTime { get; set; }

    public long EmirateId { get; set; }

    public DateTime? PoliceIncidentDateTime { get; set; }

    public string HasSupport { get; set; } = null!;

    public DateTime? Arrival1DateTime { get; set; }

    public DateTime? Arrival2DateTime { get; set; }

    public DateTime? StartArcdateTime { get; set; }

    public DateTime? EndArcdateTime { get; set; }

    public DateTime? RequestToCloseDateTime { get; set; }

    public string? Arcdelay { get; set; }

    public int? StartToEndErc { get; set; }

    public int? ArrivalToEndErc { get; set; }
}
