using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundPersonIdMapping
{
    public long Id { get; set; }

    public long ImpoundPersonId { get; set; }

    public long PersonId { get; set; }
}
