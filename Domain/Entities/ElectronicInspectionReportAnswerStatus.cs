using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ElectronicInspectionReportAnswerStatus
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }
}
