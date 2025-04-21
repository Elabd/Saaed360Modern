using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TicketRequestInfo
{
    public long TicketRequestInfoId { get; set; }

    public long TicketRequestId { get; set; }

    public DateTime? InsuranceExpiry { get; set; }

    public string? MobileNumber { get; set; }

    public string? PlateNumber { get; set; }

    public long? PlateColorId { get; set; }

    public long? PlateSourceId { get; set; }

    public long? VehicleRoleId { get; set; }

    public long? CausedInsuranceCompany { get; set; }

    public long? NationalityId { get; set; }

    public string? ReportCode { get; set; }

    public virtual TicketRequest TicketRequest { get; set; } = null!;
}
