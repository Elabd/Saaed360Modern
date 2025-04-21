using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EsVehicleInquiry
{
    public int Id { get; set; }

    public DateTime InquiryDate { get; set; }

    public string PlateNumber { get; set; } = null!;

    public int PlateSourceId { get; set; }

    public int PlateCategoryId { get; set; }

    public int PlateColorId { get; set; }

    public int? PlateKindId { get; set; }

    public int? OrganizationId { get; set; }

    public virtual ICollection<EsInsuranceInquiryResult> EsInsuranceInquiryResults { get; set; } = new List<EsInsuranceInquiryResult>();

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();

    public virtual ICollection<EsVehicleInquiryResult> EsVehicleInquiryResults { get; set; } = new List<EsVehicleInquiryResult>();

    public virtual ItemRegistrationPlateCategoryDim PlateCategory { get; set; } = null!;

    public virtual ItemRegistrationPlateColorDim PlateColor { get; set; } = null!;

    public virtual ItemRegistrationPlateKindDim? PlateKind { get; set; }

    public virtual PlateSourceDim PlateSource { get; set; } = null!;
}
