using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PasswordPolicyConfiguration
{
    public int Id { get; set; }

    public string? PropertyKey { get; set; }

    public string? PropertyValue { get; set; }

    public int? ApplicationId { get; set; }

    public virtual PasswordPolicyApplication? Application { get; set; }
}
