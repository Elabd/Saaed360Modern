using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewMoiintegrationObjection
{
    public DateTime? StartDate { get; set; }

    public int ServiceType { get; set; }

    public int IncidentSource { get; set; }

    public int SubIncidentSource { get; set; }

    public string? ChannelDesc { get; set; }

    public long? EmiratesId { get; set; }

    public int Idtype { get; set; }

    public string? TrafficCode { get; set; }

    public string? ReportNumber { get; set; }

    public string? Status { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? TimeToFinish { get; set; }
}
