using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonOtherIdentificationGuidView
{
    public Guid PersonOtherIdentificationGuid { get; set; }

    public string PersonOtherIdentificationDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public string? IdentificationCategoryCode { get; set; }

    public string? IdentificationAuthorityCode { get; set; }

    public string? IdentificationRestrictionCode { get; set; }

    public string? IdentificationClassCode { get; set; }

    public string? IdentificationStatusCode { get; set; }

    public Guid? IdenticationImageGuid { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public int? ExpirationYear { get; set; }

    public string? Identification { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public int? EffectiveYear { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
