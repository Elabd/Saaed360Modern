using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonFingerprintSetGuidView
{
    public Guid PersonFingerprintSetGuid { get; set; }

    public string PersonFingerprintSetDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid FingerprintImageGuid { get; set; }

    public string? FingerPrintPatternClassificationCode { get; set; }

    public string? FingerPrintPatternCategoryCode { get; set; }

    public string? FingerprintFingerCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}

