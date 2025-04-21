using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class StatuteDim
{
    public int StatuteId { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public string? LegalDescription { get; set; }

    public string? Urccode { get; set; }

    public string? UcrcrimeType { get; set; }

    public string? Nciccode { get; set; }

    public string? Applicability { get; set; }

    public string? StatuteCode { get; set; }

    public string? StatuteSection { get; set; }

    public string? StatuteDescription { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Charge> Charges { get; set; } = new List<Charge>();

    public virtual ICollection<IncidentStatute> IncidentStatutes { get; set; } = new List<IncidentStatute>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
