using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IdentificationAuthorityDim
{
    public int IdentificationAuthorityId { get; set; }

    public string? Description { get; set; }

    public string? Jurisdiction { get; set; }

    public string? JurisdictionCode { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonDriverLicense> PersonDriverLicenses { get; set; } = new List<PersonDriverLicense>();

    public virtual ICollection<PersonOtherIdentification> PersonOtherIdentifications { get; set; } = new List<PersonOtherIdentification>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
