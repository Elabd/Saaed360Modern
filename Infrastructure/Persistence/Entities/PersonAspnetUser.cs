using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonAspnetUser
{
    public long Id { get; set; }

    public long PersonId { get; set; }

    public Guid UserId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual AspnetUser User { get; set; } = null!;
}
