using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccrequestDispatcher
{
    public long Id { get; set; }

    public long IcccrequestId { get; set; }

    public long DispatcherId { get; set; }

    public bool Issaaed { get; set; }

    public virtual IcccincidentRequest Icccrequest { get; set; } = null!;
}
