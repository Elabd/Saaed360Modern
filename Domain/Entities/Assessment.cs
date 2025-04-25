using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Assessment
{
    public long ActivityId { get; set; }

    public DateTime EstablishedDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public string ScoreText { get; set; } = null!;

    public virtual Activity Activity { get; set; } = null!;
}
