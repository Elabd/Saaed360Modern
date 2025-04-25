using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ResponseTime
{
    public DateOnly? Day { get; set; }

    public int? CountActivity { get; set; }

    public decimal? Average { get; set; }

    public int? TotalResponseWithin15 { get; set; }

    public decimal? AverageResponseWithin15 { get; set; }

    public long EmirateId { get; set; }

    public long AreaId { get; set; }
}
