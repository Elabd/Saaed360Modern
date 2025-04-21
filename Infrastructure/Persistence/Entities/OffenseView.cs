using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OffenseView
{
    public long OffenseId { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? OffenseCodeCode { get; set; }

    public string? OffenseCodeDescription { get; set; }

    public string? EntryPassagePointCode { get; set; }

    public string? EntryPassagePointDescription { get; set; }

    public string? ExitPassagePointCode { get; set; }

    public string? ExitPassagePointDescription { get; set; }

    public bool? IdentityTheftIndicator { get; set; }

    public bool? HomeInvasionIndicator { get; set; }

    public bool? GangInvolvementIndicator { get; set; }

    public bool? TerrorismIndicator { get; set; }

    public bool? AttemptedIndicator { get; set; }

    public bool? CargoTheftIndicator { get; set; }

    public bool? DomesticViolenceIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
