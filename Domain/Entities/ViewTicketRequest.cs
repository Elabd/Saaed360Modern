using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewTicketRequest
{
    public long TicketRequestInfoId { get; set; }

    public long TicketRequestId { get; set; }

    public string ReportNumber { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string? InsuranceCompany { get; set; }

    public long? InsuranceCompanyId { get; set; }

    public DateTime? InsuranceExpiry { get; set; }

    public string? MobileNumber { get; set; }

    public long? NationalityId { get; set; }

    public long? PlateColorId { get; set; }

    public string? PlateColor { get; set; }

    public string? PlateNumber { get; set; }

    public long? PlateSourceId { get; set; }

    public string? PlateSource { get; set; }

    public long? VehicleRoleId { get; set; }

    public string? ReportCode { get; set; }
}
