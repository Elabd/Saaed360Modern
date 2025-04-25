using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistration
{
    public long ItemRegistrationId { get; set; }

    public Guid ItemRegistrationGuid { get; set; }

    public string ItemRegistrationDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public long SourceId { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public int? ItemRegistrationJurisdictionId { get; set; }

    public int? ItemRegistrationAuthorityId { get; set; }

    public int? ItemRegistrationPlateCodeId { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public string? PlateIdentification { get; set; }

    public DateOnly? RegistrationExpirationDate { get; set; }

    public DateOnly? RegistrationEffectiveDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ItemRegistrationAuthorityDim? ItemRegistrationAuthority { get; set; }

    public virtual ItemRegistrationJurisdictionDim? ItemRegistrationJurisdiction { get; set; }

    public virtual ItemRegistrationPlateCategoryDim? ItemRegistrationPlateCategory { get; set; }

    public virtual ItemRegistrationPlateCodeDim? ItemRegistrationPlateCode { get; set; }

    public virtual ItemRegistrationPlateKindDim? ItemRegistrationPlateKind { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
