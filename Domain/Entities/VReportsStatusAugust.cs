using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VReportsStatusAugust
{
    public string? ReportNumber { get; set; }

    public long? AdpreportNumber { get; set; }

    public string? ErrorMessgae { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? IsUploaded { get; set; }
}
