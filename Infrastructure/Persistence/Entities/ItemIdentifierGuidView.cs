using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemIdentifierGuidView
{
    public Guid ItemIdentifierGuid { get; set; }

    public string ItemIdentifierDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public string? ItemIdentifierLocationCode { get; set; }

    public string? ItemIdentifierDistinctiveMarkingCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
