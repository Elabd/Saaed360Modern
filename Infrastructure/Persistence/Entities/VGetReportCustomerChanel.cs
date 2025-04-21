using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VGetReportCustomerChanel
{
    public long Myedmxid { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Saaed { get; set; }

    public int? Smart { get; set; }
}
