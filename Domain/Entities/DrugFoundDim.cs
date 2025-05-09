using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrugFoundDim
{
    public int DrugFoundId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Drug> Drugs { get; set; } = new List<Drug>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
