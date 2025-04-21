using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemRegistrationGuidView
{
    public Guid ItemRegistrationGuid { get; set; }

    public string ItemRegistrationDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public string? ItemRegistrationPlateCategoryCode { get; set; }

    public string? ItemRegistrationJurisdictionCode { get; set; }

    public string? ItemRegistrationAuthorityCode { get; set; }

    public string? ItemRegistrationPlateCodeCode { get; set; }

    public string? ItemRegistrationPlateKindCode { get; set; }

    public string? PlateIdentification { get; set; }

    public DateOnly? RegistrationExpirationDate { get; set; }

    public DateOnly? RegistrationEffectiveDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
