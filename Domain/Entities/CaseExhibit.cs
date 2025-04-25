using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseExhibit
{
    public string? Description { get; set; }

    public long ActivityId { get; set; }

    public long ExhibitAcceptingOrganizationId { get; set; }

    public Guid ExhibitAcceptingOrganizationGuid { get; set; }

    public bool ExhibitAdmittedIndicator { get; set; }

    public bool ExhibitRemainingProofIndicator { get; set; }

    public int CaseExhibitStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CaseExhibitStatusDim CaseExhibitStatus { get; set; } = null!;

    public virtual Organization ExhibitAcceptingOrganization { get; set; } = null!;
}
