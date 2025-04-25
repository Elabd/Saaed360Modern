using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonMedicalConditionView
{
    public long PersonMedicalConditionId { get; set; }

    public string PersonMedicalConditionDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? PersonMedicalConditionTypeCode { get; set; }

    public string? PersonMedicalConditionTypeDescription { get; set; }

    public string? PersonMedicalCautionCode { get; set; }

    public string? PersonMedicalCautionDescription { get; set; }

    public DateTime? ConditionDateTime { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
