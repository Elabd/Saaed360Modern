using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMilitarySummaryGuidView
{
    public Guid PersonMilitarySummaryGuid { get; set; }

    public string PersonMilitarySummaryDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? MilitaryBranchCode { get; set; }

    public string? MilitaryStatusCode { get; set; }

    public string? MilitaryServiceTypeCode { get; set; }

    public string? MilitaryDischargeTypeCode { get; set; }

    public DateTime? ServiceStart { get; set; }

    public DateTime? ServiceEnd { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
