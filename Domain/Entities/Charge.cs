using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Charge
{
    public long ChargeId { get; set; }

    public Guid ChargeGuid { get; set; }

    public string ChargeDescription { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public int? ChargeSequenceNumber { get; set; }

    public int? StatuteId { get; set; }

    public int? ChargeDegreeId { get; set; }

    public int? ChargeSeverityLevelId { get; set; }

    public int? ChargeStatusId { get; set; }

    public bool? FelonyIndicator { get; set; }

    public bool? SeriousViolentIndicator { get; set; }

    public DateTime? FillingDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ArrestCharge> ArrestCharges { get; set; } = new List<ArrestCharge>();

    public virtual ICollection<CaseCharge> CaseCharges { get; set; } = new List<CaseCharge>();

    public virtual ICollection<ChargeComment> ChargeComments { get; set; } = new List<ChargeComment>();

    public virtual ChargeDegreeDim? ChargeDegree { get; set; }

    public virtual ICollection<ChargeDisposition> ChargeDispositions { get; set; } = new List<ChargeDisposition>();

    public virtual ChargeSeverityLevelDim? ChargeSeverityLevel { get; set; }

    public virtual ChargeStatusDim? ChargeStatus { get; set; }

    public virtual ICollection<OffenseChargeAssociation> OffenseChargeAssociations { get; set; } = new List<OffenseChargeAssociation>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual StatuteDim? Statute { get; set; }
}
