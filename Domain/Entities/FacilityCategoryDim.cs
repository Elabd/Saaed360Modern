using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FacilityCategoryDim
{
    public int FacilityCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
