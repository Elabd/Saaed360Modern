using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImpoundPersonIdMapping
{
    public long Id { get; set; }

    public long ImpoundPersonId { get; set; }

    public long PersonId { get; set; }
}
