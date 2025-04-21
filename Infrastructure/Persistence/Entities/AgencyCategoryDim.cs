using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AgencyCategoryDim
{
    public int AgencyCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Agency> Agencies { get; set; } = new List<Agency>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
