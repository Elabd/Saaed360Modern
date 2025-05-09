using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VwAspnetWebPartStateUser
{
    public Guid? PathId { get; set; }

    public Guid? UserId { get; set; }

    public int? DataSize { get; set; }

    public DateTime LastUpdatedDate { get; set; }
}
