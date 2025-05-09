using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UserType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<ClientApplication> ClientApplications { get; set; } = new List<ClientApplication>();
}
