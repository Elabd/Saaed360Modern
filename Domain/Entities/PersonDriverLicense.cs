using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonDriverLicense
{
    public long PersonDriverLicenseId { get; set; }

    public Guid PersonDriverLicenseGuid { get; set; }

    public string PersonDriverLicenseDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SourceId { get; set; }

    public long? DriverLicenseImageId { get; set; }

    public Guid? DriverLicenseImageGuid { get; set; }

    public int? DriverLicensePermitStatusId { get; set; }

    public int? DriverLicenseCommericalClassId { get; set; }

    public int? DriverLicenseCivilianClassId { get; set; }

    public int? IdentificationAuthorityId { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public int? ExpirationYear { get; set; }

    public string? Identification { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public int? EffectiveYear { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? PersonDrivingInsCoverageCategoryId { get; set; }

    public int? PersonDrivingInsuranceStatusId { get; set; }

    public int? RowStatusId { get; set; }

    public virtual DriverLicenseCivilianClassDim? DriverLicenseCivilianClass { get; set; }

    public virtual DriverLicenseCommericalClassDim? DriverLicenseCommericalClass { get; set; }

    public virtual PersonImage? DriverLicenseImage { get; set; }

    public virtual DriverLicensePermitStatusDim? DriverLicensePermitStatus { get; set; }

    public virtual IdentificationAuthorityDim? IdentificationAuthority { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonDrivingInsCoverageCategoryDim? PersonDrivingInsCoverageCategory { get; set; }

    public virtual PersonDrivingInsuranceStatusDim? PersonDrivingInsuranceStatus { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}

