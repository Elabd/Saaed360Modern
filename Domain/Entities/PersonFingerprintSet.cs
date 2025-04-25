using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonFingerprintSet
{
    public long PersonFingerprintSetId { get; set; }

    public Guid PersonFingerprintSetGuid { get; set; }

    public string PersonFingerprintSetDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public long FingerprintImageId { get; set; }

    public Guid FingerprintImageGuid { get; set; }

    public int? FingerPrintPatternClassificationId { get; set; }

    public int? FingerPrintPatternCategoryId { get; set; }

    public int? FingerprintFingerId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual FingerPrintPatternCategoryDim? FingerPrintPatternCategory { get; set; }

    public virtual FingerPrintPatternClassificationDim? FingerPrintPatternClassification { get; set; }

    public virtual FingerprintFingerDim? FingerprintFinger { get; set; }

    public virtual PersonImage FingerprintImage { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}

