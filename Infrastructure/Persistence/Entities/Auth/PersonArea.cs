using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities.Auth;

public partial class PersonArea
{
    public long personAreaId { get; set; }

    public long? PersonId { get; set; }

    public long? AreaId { get; set; }
}
