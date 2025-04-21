using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RiskScoreAxa
{
    public double? ClaimNo { get; set; }

    public string? Chass { get; set; }

    public double? Tcn { get; set; }

    public string? StatusInMotori { get; set; }

    public double? FraudScoure { get; set; }
}
