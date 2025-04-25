using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistrationView
{
    public long ItemRegistrationId { get; set; }

    public string ItemRegistrationDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public string? ItemRegistrationPlateCategoryCode { get; set; }

    public string? ItemRegistrationPlateCategoryDescription { get; set; }

    public string? ItemRegistrationJurisdictionCode { get; set; }

    public string? ItemRegistrationJurisdictionDescription { get; set; }

    public string? ItemRegistrationAuthorityCode { get; set; }

    public string? ItemRegistrationAuthorityDescription { get; set; }

    public string? ItemRegistrationPlateCodeCode { get; set; }

    public string? ItemRegistrationPlateCodeDescription { get; set; }

    public string? ItemRegistrationPlateKindCode { get; set; }

    public string? ItemRegistrationPlateKindDescription { get; set; }

    public string? PlateIdentification { get; set; }

    public DateOnly? RegistrationExpirationDate { get; set; }

    public DateOnly? RegistrationEffectiveDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
