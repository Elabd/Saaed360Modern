using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TaskInvolvementDim
{
    public long TaskInvolvementId { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public byte[]? TimpStamp { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public virtual ICollection<ActivityTask> ActivityTasks { get; set; } = new List<ActivityTask>();
}
