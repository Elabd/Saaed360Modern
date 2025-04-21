using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BondPaymentDimcodeView
{
    public string? BondPaymentDescription { get; set; }

    public string? BondPaymentCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
