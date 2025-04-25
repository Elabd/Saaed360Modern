using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonFingerprintSetView
{
    public long PersonFingerprintSetId { get; set; }

    public string PersonFingerprintSetDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long FingerprintImageId { get; set; }

    public string? FingerPrintPatternClassificationCode { get; set; }

    public string? FingerPrintPatternClassificationDescription { get; set; }

    public string? FingerPrintPatternCategoryCode { get; set; }

    public string? FingerPrintPatternCategoryDescription { get; set; }

    public string? FingerprintFingerCode { get; set; }

    public string? FingerprintFingerDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}

