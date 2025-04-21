using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class JudicialOfficialBarStatusDim
{
    public int JudicialOfficialBarStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<JudicialOfficial> JudicialOfficials { get; set; } = new List<JudicialOfficial>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
