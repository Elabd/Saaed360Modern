using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryStyleDim
{
    public int JewelryStyleId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Jewelry> Jewelries { get; set; } = new List<Jewelry>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
