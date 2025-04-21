using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewMdtpersonAspnetUserSyncHelper
{
    public long Id { get; set; }

    public long PersonId { get; set; }

    public Guid UserId { get; set; }
}
