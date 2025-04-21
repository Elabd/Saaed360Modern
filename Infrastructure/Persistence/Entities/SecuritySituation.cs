using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SecuritySituation
{
    public long Id { get; set; }

    public string? SecuritySituationNumber { get; set; }

    public string? Descrption { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? SecuritySituationTypeId { get; set; }

    public long? CityId { get; set; }

    public long? AreaId { get; set; }

    public double? Latitude { get; set; }

    public double? Longtitude { get; set; }

    public string? Address { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public int? CurrentStatusId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public string? RejectionReason { get; set; }

    public int? SecuritySituationSourceId { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? SecuritySituationDate { get; set; }

    public int? SourceId { get; set; }

    public virtual ReportAreaDim? Area { get; set; }

    public virtual CityDim? City { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual SecuritySituationStatusDim? CurrentStatus { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual ICollection<SecuritySituationAttachement> SecuritySituationAttachements { get; set; } = new List<SecuritySituationAttachement>();

    public virtual SecuritySituationSourceDim? SecuritySituationSource { get; set; }

    public virtual ICollection<SecuritySituationStatus> SecuritySituationStatuses { get; set; } = new List<SecuritySituationStatus>();

    public virtual SecuritySituationTypeDim? SecuritySituationType { get; set; }
}
