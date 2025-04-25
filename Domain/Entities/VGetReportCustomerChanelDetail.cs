using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VGetReportCustomerChanelDetail
{
    public int VehicleDataId { get; set; }

    public string? ServiceName { get; set; }

    public int ServiceTypeId { get; set; }

    public string? CustomerName { get; set; }

    public string? Nationality { get; set; }

    public string? MobileNumber { get; set; }

    public string Email { get; set; } = null!;

    public string? Tcn { get; set; }

    public string? ReportSource { get; set; }

    public DateTime ReportDateTime { get; set; }
}
