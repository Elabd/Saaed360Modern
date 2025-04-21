using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Profile
{
    public Guid UserId { get; set; }

    public string PropertyNames { get; set; } = null!;

    public string PropertyValueStrings { get; set; } = null!;

    public byte[] PropertyValueBinary { get; set; } = null!;

    public DateTime LastUpdatedDate { get; set; }

    public virtual User1 User { get; set; } = null!;
}
