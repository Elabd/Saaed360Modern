using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TimeCategoryDim
{
    public int TimeCategoryId { get; set; }

    public int? ValueInMinutes { get; set; }

    public int? ValueInHours { get; set; }

    public string? MinutesRange { get; set; }

    public string? HoursRange { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
