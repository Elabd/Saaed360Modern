using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BireportsType
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<BireportsTable> BireportsTables { get; set; } = new List<BireportsTable>();
}
