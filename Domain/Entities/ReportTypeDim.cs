using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportTypeDim
{
    public int ReportTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool Isdeleted { get; set; }

    public bool IsDefaultForReportConstruction { get; set; }

    public virtual ICollection<ReportField> ReportFields { get; set; } = new List<ReportField>();

    public virtual ICollection<ReportStatusToReportTypeMap> ReportStatusToReportTypeMaps { get; set; } = new List<ReportStatusToReportTypeMap>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
