using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonOtherIdentification
{
    public long PersonOtherIdentificationId { get; set; }

    public Guid PersonOtherIdentificationGuid { get; set; }

    public string PersonOtherIdentificationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public int? IdentificationCategoryId { get; set; }

    public int? IdentificationAuthorityId { get; set; }

    public int? IdentificationRestrictionId { get; set; }

    public int? IdentificationClassId { get; set; }

    public int? IdentificationStatusId { get; set; }

    public long? IdenticationImageId { get; set; }

    public Guid? IdenticationImageGuid { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public int? ExpirationYear { get; set; }

    public string? Identification { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public int? EffectiveYear { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual PersonImage? IdenticationImage { get; set; }

    public virtual IdentificationAuthorityDim? IdentificationAuthority { get; set; }

    public virtual IdentificationCategoryDim? IdentificationCategory { get; set; }

    public virtual IdentificationClassDim? IdentificationClass { get; set; }

    public virtual IdentificationRestrictionDim? IdentificationRestriction { get; set; }

    public virtual IdentificationtStatusDim? IdentificationStatus { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
