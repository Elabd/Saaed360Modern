using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedTransferedReport
{
    public long Incidentid { get; set; }

    public long FirstTransferActivityId { get; set; }

    public long? ClosedTransfer { get; set; }

    public string? FirstTransferDescription { get; set; }

    public string? ClosedTransferDescription { get; set; }

    public int? ReportId { get; set; }

    public long? ParentId { get; set; }

    public long? ChildId { get; set; }

    public string? Childs { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public long? FirstTransferOrgId { get; set; }

    public string? FirstTransferOrganizationName { get; set; }

    public long? LastTransferOrgId { get; set; }

    public string? ReasonNameLast { get; set; }

    public string? LastTransferOrganizationName { get; set; }

    public int FirstTransferReason { get; set; }

    public string? ReasonName { get; set; }

    public int? ReasonIdLast { get; set; }

    public string? LastOrgDescription { get; set; }

    public string? FirstOrgDescription { get; set; }

    public long? EmirateId { get; set; }

    public long? CityId { get; set; }

    public long? SectorId { get; set; }

    public long? RegionId { get; set; }

    public long? StreetId { get; set; }

    public long? ActivityId { get; set; }

    public string? ActivityDescription { get; set; }
}
