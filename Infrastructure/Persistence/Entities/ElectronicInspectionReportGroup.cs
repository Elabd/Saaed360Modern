using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportGroup
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ElectronicInspectionReportUser> ElectronicInspectionReportUsers { get; set; } = new List<ElectronicInspectionReportUser>();
}
