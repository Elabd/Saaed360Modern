using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoLocationSubDivisionDim
{
    public int GeoLocationSubDivisionId { get; set; }

    public string? State { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }

    public string? SubDivision { get; set; }

    public string? SubDivisionCode { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SubscriptionSubdivision> SubscriptionSubdivisions { get; set; } = new List<SubscriptionSubdivision>();
}
