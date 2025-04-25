using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtOrderServiceCautionDim
{
    public int CourtOrderServiceCautionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<CourtOrder> CourtOrders { get; set; } = new List<CourtOrder>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

