using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonReportsAssignment
{
    public long Id { get; set; }

    public long PersonId { get; set; }

    public int ReportId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual DataInsightHubReport Report { get; set; } = null!;
}
