using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionPolygonCategoryDimcodeView
{
    public string? SubscriptionPolygonCategoryDescription { get; set; }

    public string? SubscriptionPolygonCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
