using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportStatusDim
{
    public int ReportStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool Isdeleted { get; set; }

    public bool IsDefaultForReportConstruction { get; set; }

    public bool IsDraftStatus { get; set; }

    public int? ActualReportStatusId { get; set; }

    public int? MappedFinalStatusId { get; set; }

    public virtual ReportStatusDim? ActualReportStatus { get; set; }

    public virtual ICollection<ReportStatusDim> InverseActualReportStatus { get; set; } = new List<ReportStatusDim>();

    public virtual ICollection<ReportStatusDim> InverseMappedFinalStatus { get; set; } = new List<ReportStatusDim>();

    public virtual ReportStatusDim? MappedFinalStatus { get; set; }

    public virtual ICollection<ReportChangeStatusLog> ReportChangeStatusLogNewStatusNavigations { get; set; } = new List<ReportChangeStatusLog>();

    public virtual ICollection<ReportChangeStatusLog> ReportChangeStatusLogOldStatusNavigations { get; set; } = new List<ReportChangeStatusLog>();

    public virtual ICollection<ReportStatusToReportTypeMap> ReportStatusToReportTypeMaps { get; set; } = new List<ReportStatusToReportTypeMap>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
