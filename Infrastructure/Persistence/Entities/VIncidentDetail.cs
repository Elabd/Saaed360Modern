using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VIncidentDetail
{
    public string? Description { get; set; }

    public string? Code { get; set; }

    public long TransationId { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public int? ReportId { get; set; }

    public string? StatusDescription { get; set; }

    public string? StatusCode { get; set; }

    public long? ItemId { get; set; }

    public int StatusId { get; set; }

    public string? Name { get; set; }

    public long? Teid { get; set; }

    public string Tename { get; set; } = null!;

    public DateTime CreationDateTime { get; set; }

    public long ActivityId { get; set; }

    public string CreatedBy { get; set; } = null!;
}
