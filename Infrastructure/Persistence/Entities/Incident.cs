using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Incident
{
    public long ActivityId { get; set; }

    public int IncidentActivityCategoryId { get; set; }

    public int? IncidentMethodId { get; set; }

    public int? IncidentLevelId { get; set; }

    public int? IncidentForceLevelId { get; set; }

    public bool? ForceInvolvedIndicator { get; set; }

    public int? IncidentExceptionalClearanceId { get; set; }

    public DateTime? ExceptionalClearanceDate { get; set; }

    public bool? InvolvedJuvenile { get; set; }

    public bool? InvolvedSenior { get; set; }

    public bool? InvolvedDomestic { get; set; }

    public bool? InvolvedGang { get; set; }

    public bool? InvolvedSubstance { get; set; }

    public bool? InvolvedCivilian { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual IncidentActivityCategoryDim IncidentActivityCategory { get; set; } = null!;

    public virtual IncidentExceptionalClearanceDim? IncidentExceptionalClearance { get; set; }

    public virtual IncidentForceLevelDim? IncidentForceLevel { get; set; }

    public virtual IncidentLevelDim? IncidentLevel { get; set; }

    public virtual IncidentMethodDim? IncidentMethod { get; set; }
}
