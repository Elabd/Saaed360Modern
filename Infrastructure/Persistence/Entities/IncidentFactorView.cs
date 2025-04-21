using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentFactorView
{
    public long IncidentFactorId { get; set; }

    public string IncidentFactorDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? FactorCode { get; set; }

    public string? FactorDescription { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
