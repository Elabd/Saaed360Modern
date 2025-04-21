using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReleaseAuthorizationCategoryDim
{
    public int ReleaseAuthorizationCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Release> Releases { get; set; } = new List<Release>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
