using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportUser
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? RoleName { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<ElectronicInspectionReportGroup> ElectronicInspectionReportGroups { get; set; } = new List<ElectronicInspectionReportGroup>();
}
