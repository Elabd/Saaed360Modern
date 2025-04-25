using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewActivityResponsePerEmirate
{
    public long ActivityId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public long EmirateId { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public DateTime? StartDate { get; set; }
}
