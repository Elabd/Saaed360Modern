using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CustodyTransferActionDimcodeView
{
    public string? CustodyTransferActionDescription { get; set; }

    public string? CustodyTransferActionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
