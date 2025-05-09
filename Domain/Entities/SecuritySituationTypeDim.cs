using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SecuritySituationTypeDim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public int? SecuritySituationMonitorLevelId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual SecuritySituationMonitorLevelDim? SecuritySituationMonitorLevel { get; set; }

    public virtual ICollection<SecuritySituation> SecuritySituations { get; set; } = new List<SecuritySituation>();
}
