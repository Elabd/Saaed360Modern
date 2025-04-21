using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Case
{
    public long ActivityId { get; set; }

    public int CaseCategoryId { get; set; }

    public int CaseSolvabilityId { get; set; }

    public string? CaseIdentification { get; set; }

    public int? CaseOpenedYear { get; set; }

    public DateOnly? CaseDate { get; set; }

    public TimeOnly? CaseTime { get; set; }

    public DateOnly? ReviewDate { get; set; }

    public DateOnly? NextReviewDate { get; set; }

    public string? SolvabilityPoints { get; set; }

    public int CaseStatusId { get; set; }

    public string? LongCaseTitle { get; set; }

    public string? ShortCaseTitle { get; set; }

    public bool CaseDefendantSelfRepIndicator { get; set; }

    public bool CaseDomesticViolenceIndicator { get; set; }

    public bool CaseDrivingImpairedIndicator { get; set; }

    public bool CaseDrivingIntoxicatedIndicator { get; set; }

    public bool CaseInformationAdmissibleIndicator { get; set; }

    public bool CaseProtectionOrderIndicator { get; set; }

    public bool CaseVerdictGivenIndicator { get; set; }

    public bool CaseVictimNotProsecutingIndicator { get; set; }

    public DateTime? CaseCapiasDate { get; set; }

    public DateTime? CaseContinuanceDate { get; set; }

    public int CaseRestrictionId { get; set; }

    public DateTime? CaseRestrictionDate { get; set; }

    public int CaseSecurityId { get; set; }

    public int CaseSeverityId { get; set; }

    public int CaseTerminationCategoryId { get; set; }

    public int CaseTerminationStageId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CaseCategoryDim CaseCategory { get; set; } = null!;

    public virtual CaseRestrictionDim CaseRestriction { get; set; } = null!;

    public virtual CaseSecurityDim CaseSecurity { get; set; } = null!;

    public virtual CaseSeverityDim CaseSeverity { get; set; } = null!;

    public virtual CaseSolvabilityDim CaseSolvability { get; set; } = null!;

    public virtual CaseStatusDim CaseStatus { get; set; } = null!;

    public virtual CaseTerminationCategoryDim CaseTerminationCategory { get; set; } = null!;

    public virtual CaseTerminationStageDim CaseTerminationStage { get; set; } = null!;
}
