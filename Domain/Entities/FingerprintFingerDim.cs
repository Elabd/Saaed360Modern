using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FingerprintFingerDim
{
    public int FingerPrintFingerId { get; set; }

    public string? Position { get; set; }

    public string? Finger { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonFingerprintSet> PersonFingerprintSets { get; set; } = new List<PersonFingerprintSet>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

