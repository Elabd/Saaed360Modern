using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AdpresponseCalculationRequest
{
    public long Id { get; set; }

    public DateTime DateTimeToCalculate { get; set; }

    public bool IsDone { get; set; }

    public DateTime CreationDate { get; set; }
}
