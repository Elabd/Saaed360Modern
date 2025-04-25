using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LogedInPatrol
{
    public int Id { get; set; }

    public long ItemId { get; set; }

    public string SectorCode { get; set; } = null!;

    public string PersonName { get; set; } = null!;

    public long PersonId { get; set; }

    public long SectorId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual Area Sector { get; set; } = null!;
}
