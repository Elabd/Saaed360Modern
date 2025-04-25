using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Evidence
{
    public long ItemId { get; set; }

    public long EvidenceCollectorId { get; set; }

    public Guid EvidenceCollectorGuid { get; set; }

    public decimal? EvidenceAmount { get; set; }

    public int? EvidenceQuantity { get; set; }

    public virtual Person EvidenceCollector { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;
}
