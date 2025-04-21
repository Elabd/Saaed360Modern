using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserCodesForgetPassword
{
    public long Id { get; set; }

    public Guid? UserId { get; set; }

    public string? Code { get; set; }

    public DateTime? CodeGenerationDate { get; set; }

    public int FailedCount { get; set; }

    public virtual AspnetUser? User { get; set; }
}
