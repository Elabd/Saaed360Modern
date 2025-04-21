using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities.Auth;

public partial class PersonAspnetUser
{
    public long ID { get; set; }

    public long PersonID { get; set; }

    public Guid UserID { get; set; }

    public virtual aspnet_User User { get; set; } = null!;
}
