using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RecentReportForMotori
{
    public int ReportId { get; set; }

    public Guid ReportGuid { get; set; }

    public string? ReportNumber { get; set; }

    public int? ReportTypeId { get; set; }

    public int? ReportStatusId { get; set; }

    public DateTime ReportDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsUploaded { get; set; }

    public bool? IsTransferedFromPolice { get; set; }

    public DateTime? PoliceTransferDateTime { get; set; }
}
