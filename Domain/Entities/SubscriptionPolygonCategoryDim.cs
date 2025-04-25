using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionPolygonCategoryDim
{
    public int SubscriptionPolygonCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? SourceTable { get; set; }

    public string? SourceTableIdColumn { get; set; }

    public string? SourceTablePolygonColumn { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SubscriptionPolygon> SubscriptionPolygons { get; set; } = new List<SubscriptionPolygon>();
}
