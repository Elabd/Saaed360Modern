using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class StatusDim
{
    public int StatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityConvertToStation> ActivityConvertToStations { get; set; } = new List<ActivityConvertToStation>();

    public virtual ICollection<ActivityTransaction> ActivityTransactions { get; set; } = new List<ActivityTransaction>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<SubjectOrganization> SubjectOrganizations { get; set; } = new List<SubjectOrganization>();
}
