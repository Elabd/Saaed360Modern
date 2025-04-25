using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ObjectionLog
{
    public long LogId { get; set; }

    public long ObjectionId { get; set; }

    public int? OldStatusId { get; set; }

    public int NewStatusId { get; set; }

    public long? PersonId { get; set; }

    public DateTime LogDateTime { get; set; }

    public string? ClientName { get; set; }

    public bool? IsPoliceAction { get; set; }

    public virtual Objection Objection { get; set; } = null!;

    public virtual Person? Person { get; set; }
}
