using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonMedicalCondition
{
    public long PersonMedicalConditionId { get; set; }

    public Guid PersonMedicalConditionGuid { get; set; }

    public string PersonMedicalConditionDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? PersonMedicalConditionTypeId { get; set; }

    public int? PersonMedicalCautionId { get; set; }

    public DateTime? ConditionDateTime { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonMedicalCautionDim? PersonMedicalCaution { get; set; }

    public virtual PersonMedicalConditionTypeDim? PersonMedicalConditionType { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
