using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonHistoricalTokenShared
{
    public long Id { get; set; }

    public long PersonId { get; set; }

    public long EventId { get; set; }

    public Guid TokenGuid { get; set; }

    public DateTime CreateDateTime { get; set; }

    public DateTime ExpiryDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
