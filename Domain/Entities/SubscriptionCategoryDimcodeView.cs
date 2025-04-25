using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionCategoryDimcodeView
{
    public string? SubscriptionCategoryDescription { get; set; }

    public string? SubscriptionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
