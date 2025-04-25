using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SourceDetail
{
    public long SourceDetailId { get; set; }

    public long SourceId { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

    public virtual ICollection<ActivityAssociation> ActivityAssociations { get; set; } = new List<ActivityAssociation>();

    public virtual Source Source { get; set; } = null!;
}
