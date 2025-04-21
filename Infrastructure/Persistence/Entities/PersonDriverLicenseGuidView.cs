using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonDriverLicenseGuidView
{
    public Guid PersonDriverLicenseGuid { get; set; }

    public string PersonDriverLicenseDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid? DriverLicenseImageGuid { get; set; }

    public string? DriverLicensePermitStatusCode { get; set; }

    public string? DriverLicenseCommericalClassCode { get; set; }

    public string? DriverLicenseCivilianClassCode { get; set; }

    public string? IdentificationAuthorityCode { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public int? ExpirationYear { get; set; }

    public string? Identification { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public int? EffectiveYear { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? PersonDrivingInsCoverageCategoryCode { get; set; }

    public string? PersonDrivingInsuranceStatusCode { get; set; }

    public string? RowStatusCode { get; set; }
}

