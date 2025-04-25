using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsInsuranceInquiryResult
{
    public int Id { get; set; }

    public int? VehicleInquiryId { get; set; }

    public string? PolicyNumber { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? InsuranceCompanyNameAr { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? InsuranceTypeName { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? PolicyStatusCode { get; set; }

    public virtual EsVehicleInquiry? VehicleInquiry { get; set; }
}
