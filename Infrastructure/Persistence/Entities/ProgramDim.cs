using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ProgramDim
{
    public int ProgramId { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public string ProgramName { get; set; } = null!;

    public string? ProgramCategory { get; set; }

    public string? ProgramCategoryCode { get; set; }

    public string? ProgramArea { get; set; }

    public string? ProgramAreaCode { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ProgramParticipation> ProgramParticipations { get; set; } = new List<ProgramParticipation>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
