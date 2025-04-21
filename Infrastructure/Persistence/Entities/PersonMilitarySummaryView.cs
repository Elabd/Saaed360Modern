using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonMilitarySummaryView
{
    public long PersonMilitarySummaryId { get; set; }

    public string PersonMilitarySummaryDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? MilitaryBranchCode { get; set; }

    public string? MilitaryBranchDescription { get; set; }

    public string? MilitaryStatusCode { get; set; }

    public string? MilitaryStatusDescription { get; set; }

    public string? MilitaryServiceTypeCode { get; set; }

    public string? MilitaryServiceTypeDescription { get; set; }

    public string? MilitaryDischargeTypeCode { get; set; }

    public string? MilitaryDischargeTypeDescription { get; set; }

    public DateTime? ServiceStart { get; set; }

    public DateTime? ServiceEnd { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
