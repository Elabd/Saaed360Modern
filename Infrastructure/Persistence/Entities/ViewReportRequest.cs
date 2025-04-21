using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewReportRequest
{
    public long RequestId { get; set; }

    public int? ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime? RequestCreationDate { get; set; }

    public int? RequestTypeId { get; set; }

    public int? SourceOfModificationId { get; set; }

    public DateTime? ReportModificationDate { get; set; }

    public long? CreatedBy { get; set; }

    public string? CreatedByName { get; set; }

    public DateTime? RequestModificationDate { get; set; }

    public long? RequestModifiedBy { get; set; }

    public string? RequestModifiedByName { get; set; }

    public string? RequestNumber { get; set; }

    public string? RequestTypeDescription { get; set; }

    public string? RequestTypeCode { get; set; }

    public DateTime? TransferDate { get; set; }

    public long? TransferedBy { get; set; }

    public string? TransferedByName { get; set; }

    public int? ReportModificationStatusId { get; set; }

    public string? ReportModificationStatusCode { get; set; }

    public bool? IsExternal { get; set; }

    public string? SourceOfModificationName { get; set; }
}
