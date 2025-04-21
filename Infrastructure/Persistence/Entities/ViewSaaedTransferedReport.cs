using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewSaaedTransferedReport
{
    public long Incidentid { get; set; }

    public int ActivityCategoryId { get; set; }

    public long TransferId { get; set; }

    public int TransferStatusId { get; set; }

    public string? TransferStatusCode { get; set; }

    public long OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public int Reasonid { get; set; }

    public string? Description { get; set; }

    public string? TransferDescription { get; set; }

    public long TransferedBy { get; set; }

    public string? TransferedByName { get; set; }

    public DateTime TransferTime { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public long AreaId { get; set; }

    public bool IsCurrentOrganization { get; set; }

    public int TransferStatusCaseId { get; set; }

    public long? LastModifiedBy { get; set; }

    public string? StatusDescAr { get; set; }

    public string? StatusDescEn { get; set; }

    public bool? IsTs { get; set; }
}
