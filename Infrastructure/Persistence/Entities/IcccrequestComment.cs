using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccrequestComment
{
    public long Id { get; set; }

    public long IcccrequestId { get; set; }

    public string Comment { get; set; } = null!;

    public DateTime RecievedTime { get; set; }

    public bool FromSaaed { get; set; }

    public long PersonId { get; set; }

    public bool FromTrafficExpert { get; set; }

    public virtual IcccincidentRequest Icccrequest { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
