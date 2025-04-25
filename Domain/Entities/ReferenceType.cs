using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReferenceType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string DescriptionAr { get; set; } = null!;

    public virtual ICollection<Action> Actions { get; set; } = new List<Action>();
}
