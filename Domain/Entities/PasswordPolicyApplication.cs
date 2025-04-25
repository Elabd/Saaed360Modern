using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PasswordPolicyApplication
{
    public int Id { get; set; }

    public string ApplicationName { get; set; } = null!;

    public virtual ICollection<PasswordPolicyConfiguration> PasswordPolicyConfigurations { get; set; } = new List<PasswordPolicyConfiguration>();
}
