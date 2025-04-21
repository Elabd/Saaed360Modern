using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FacilityMemberCategoryDim
{
    public int FacilityMemberCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
