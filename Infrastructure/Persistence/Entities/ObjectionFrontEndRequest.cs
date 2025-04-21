using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ObjectionFrontEndRequest
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? ReportNumber { get; set; }

    public string? ClientName { get; set; }

    public string? MobileNumber { get; set; }
}
