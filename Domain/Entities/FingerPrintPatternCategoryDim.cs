using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FingerPrintPatternCategoryDim
{
    public int FingerPrintPatternCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Fpc { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonFingerprintSet> PersonFingerprintSets { get; set; } = new List<PersonFingerprintSet>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

