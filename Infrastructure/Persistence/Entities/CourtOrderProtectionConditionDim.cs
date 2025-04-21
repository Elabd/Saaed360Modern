using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtOrderProtectionConditionDim
{
    public int CourtOrderProtectionConditionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<CourtOrder> CourtOrders { get; set; } = new List<CourtOrder>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
