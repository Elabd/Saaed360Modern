using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMedicalConditionGuidView
{
    public Guid PersonMedicalConditionGuid { get; set; }

    public string PersonMedicalConditionDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? PersonMedicalConditionTypeCode { get; set; }

    public string? PersonMedicalCautionCode { get; set; }

    public DateTime? ConditionDateTime { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
