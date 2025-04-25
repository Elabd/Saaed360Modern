using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VTerolsDetail
{
    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public Guid UserId { get; set; }

    public Guid Terole { get; set; }

    public Guid? SupervisorRole { get; set; }

    public int IsSupervisor { get; set; }
}
