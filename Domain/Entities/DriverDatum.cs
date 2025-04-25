using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DriverDatum
{
    public int DriverDataId { get; set; }

    public int? VehicleDataId { get; set; }

    public string? TrafficCode { get; set; }

    public string? LicenseNumber { get; set; }

    public int? LicensePlateListSourceId { get; set; }

    public bool? IsDriverHaveLicense { get; set; }

    public string? Name { get; set; }

    public int? NationalityId { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? LicenseCategoryId { get; set; }

    public int? GenderId { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? MobileNumber { get; set; }

    public int? CareerId { get; set; }

    public int? EducationStatusId { get; set; }

    public string? Address { get; set; }

    public int? EscapedStatusId { get; set; }

    public int? DriverStatusId { get; set; }

    public int? DriverDrinkingStatusId { get; set; }

    public int? ConfiscationDocumentTypeId { get; set; }

    public int? ConfiscationLocationId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? ConfiscationStatusId { get; set; }

    public bool? IsWanted { get; set; }

    public virtual CareerDim? Career { get; set; }

    public virtual ConfiscationDocumentTypeDim? ConfiscationDocumentType { get; set; }

    public virtual ConfiscationLocationDim? ConfiscationLocation { get; set; }

    public virtual ConfiscationStatusDim? ConfiscationStatus { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<DriverDataConfiscationLog> DriverDataConfiscationLogs { get; set; } = new List<DriverDataConfiscationLog>();

    public virtual DriverDrinkingStatusDim? DriverDrinkingStatus { get; set; }

    public virtual DriverStatusDim? DriverStatus { get; set; }

    public virtual EducationStatusDim? EducationStatus { get; set; }

    public virtual EscapedStatusDim? EscapedStatus { get; set; }

    public virtual GenderDim? Gender { get; set; }

    public virtual LicenseCategoryDim? LicenseCategory { get; set; }

    public virtual LicensePlateListSourceDim? LicensePlateListSource { get; set; }

    public virtual NationalityDim? Nationality { get; set; }

    public virtual VehicleDatum? VehicleData { get; set; }
}
