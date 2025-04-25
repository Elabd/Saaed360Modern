using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RealestateCategoryDim
{
    public int RealestateCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Realestate> Realestates { get; set; } = new List<Realestate>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
