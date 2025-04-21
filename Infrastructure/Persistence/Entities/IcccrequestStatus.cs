using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccrequestStatus
{
    public int RequestStatusId { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public bool IsClosed { get; set; }

    public virtual ICollection<IcccincidentRequest> IcccincidentRequests { get; set; } = new List<IcccincidentRequest>();
}
