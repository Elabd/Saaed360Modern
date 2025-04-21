using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityJurorView
{
    public long PersonId { get; set; }

    public string Description { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? PersonStatusCode { get; set; }

    public string? PersonStatusDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Moniker { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public int? PersonCategoryId { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public string? JurorIdentification { get; set; }

    public string? JurorPanelIdentification { get; set; }

    public DateTime? JurorDismissedDate { get; set; }

    public bool JurorDismissedIndicator { get; set; }

    public string? JurorDismissedReasonCode { get; set; }

    public string? JurorDismissedReasonDescription { get; set; }

    public bool JurorForemanIndicator { get; set; }

    public bool JurorPrimaryIndicator { get; set; }

    public long ActivityPersonId { get; set; }

    public string ActivityPersonDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? PersonInvolvementDescription { get; set; }
}
