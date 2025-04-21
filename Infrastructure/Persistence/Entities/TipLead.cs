using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TipLead
{
    public long ActivityId { get; set; }

    public int? TipLeadCategoryId { get; set; }

    public int? PolicyId { get; set; }

    public int? TipLeadSourceCategoryId { get; set; }

    public int? PriorityHighLowId { get; set; }

    public int? TipLeadContentValidityId { get; set; }

    public int? TipLeadReliablityId { get; set; }

    public int? TipLeadSourceMethodContactId { get; set; }

    public string? Description { get; set; }

    public string? Summary { get; set; }

    public DateTime? TipLeadDateTime { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public string? TrackingNumber { get; set; }

    public string? TargetFileNumber { get; set; }

    public string? Nisuri { get; set; }

    public DateTime? NisdateTime { get; set; }

    public string? NistrackingNumber { get; set; }

    public bool? PrivacyIndicator { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual PolicyDim? Policy { get; set; }

    public virtual HighLowDim? PriorityHighLow { get; set; }

    public virtual TipLeadCategoryDim? TipLeadCategory { get; set; }

    public virtual TipLeadContentValidityDim? TipLeadContentValidity { get; set; }

    public virtual TipLeadReliabilityDim? TipLeadReliablity { get; set; }

    public virtual TipLeadSourceCategoryDim? TipLeadSourceCategory { get; set; }

    public virtual TipLeadSourceMethodContactDim? TipLeadSourceMethodContact { get; set; }
}
