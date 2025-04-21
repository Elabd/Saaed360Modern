using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Alert
{
    public long ActivityId { get; set; }

    public int? AlertCategoryId { get; set; }

    public int? AlertUrgencyId { get; set; }

    public int? AlertSeverityId { get; set; }

    public int? AlertCertaintyId { get; set; }

    public int? AlertAudienceId { get; set; }

    public int? AlertTargetId { get; set; }

    public int? AlertSenderId { get; set; }

    public int? AlertInstructionId { get; set; }

    public int? AlertReasonId { get; set; }

    public int? AlertEventId { get; set; }

    public int? AlertHandlingId { get; set; }

    public string? Headline { get; set; }

    public string? Message { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual AlertAudienceDim? AlertAudience { get; set; }

    public virtual AlertCategoryDim? AlertCategory { get; set; }

    public virtual AlertCertaintyDim? AlertCertainty { get; set; }

    public virtual AlertEventDim? AlertEvent { get; set; }

    public virtual AlertHandlingDim? AlertHandling { get; set; }

    public virtual AlertInstructionDim? AlertInstruction { get; set; }

    public virtual AlertReasonDim? AlertReason { get; set; }

    public virtual AlertSenderDim? AlertSender { get; set; }

    public virtual AlertSeverityDim? AlertSeverity { get; set; }

    public virtual AlertTargetDim? AlertTarget { get; set; }

    public virtual AlertUrgencyDim? AlertUrgency { get; set; }
}
