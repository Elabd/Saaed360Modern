using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentFactorGuidView
{
    public Guid IncidentFactorGuid { get; set; }

    public string IncidentFactorDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? FactorCode { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
