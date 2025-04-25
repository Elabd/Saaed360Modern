using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SecuritySituationStatus
{
    public long Id { get; set; }

    public long? SecuritySituationId { get; set; }

    public int? SecuritySituationStatusId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual SecuritySituation? SecuritySituation { get; set; }

    public virtual SecuritySituationStatusDim? SecuritySituationStatusNavigation { get; set; }
}
