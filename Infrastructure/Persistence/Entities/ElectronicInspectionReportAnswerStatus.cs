using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportAnswerStatus
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }
}
