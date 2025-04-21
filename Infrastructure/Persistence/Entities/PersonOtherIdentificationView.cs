using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonOtherIdentificationView
{
    public long PersonOtherIdentificationId { get; set; }

    public string PersonOtherIdentificationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? IdentificationCategoryCode { get; set; }

    public string? IdentificationCategoryDescription { get; set; }

    public string? IdentificationAuthorityJurisdiction { get; set; }

    public string? IdentificationAuthorityCode { get; set; }

    public string? IdentificationRestrictionCode { get; set; }

    public string? IdentificationRestrictionDescription { get; set; }

    public string? IdentificationClassCode { get; set; }

    public string? IdentificationClassDescription { get; set; }

    public string? IdentificationStatusCode { get; set; }

    public string? IdentificationStatusDescription { get; set; }

    public long? IdenticationImageId { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public int? ExpirationYear { get; set; }

    public string? Identification { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public int? EffectiveYear { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
