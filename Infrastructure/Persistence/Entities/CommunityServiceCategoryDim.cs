using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CommunityServiceCategoryDim
{
    public int CommunityServiceCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<CommunityService> CommunityServices { get; set; } = new List<CommunityService>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

