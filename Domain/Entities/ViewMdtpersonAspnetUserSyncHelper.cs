using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewMdtpersonAspnetUserSyncHelper
{
    public long Id { get; set; }

    public long PersonId { get; set; }

    public Guid UserId { get; set; }
}
