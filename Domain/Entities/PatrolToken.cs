using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PatrolToken
{
    public long PatrolTokenId { get; set; }

    public long PatrolId { get; set; }

    public string Token { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime? ModifiedTime { get; set; }
}
