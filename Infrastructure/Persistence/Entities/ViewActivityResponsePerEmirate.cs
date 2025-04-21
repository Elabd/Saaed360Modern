using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewActivityResponsePerEmirate
{
    public long ActivityId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public long EmirateId { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public DateTime? StartDate { get; set; }
}
