using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SecuritySituationMonitorLevelDim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<SecuritySituationTypeDim> SecuritySituationTypeDims { get; set; } = new List<SecuritySituationTypeDim>();
}
