using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AdpresponseCalculationRequestsMonthly
{
    public long Id { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public bool IsDone { get; set; }

    public DateTime CreationDate { get; set; }
}
