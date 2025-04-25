using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ElectronicInspectionQuestion
{
    public long Id { get; set; }

    public string ArName { get; set; } = null!;

    public string EnName { get; set; } = null!;

    public int? Code { get; set; }

    public virtual ICollection<ElectronicInspectionAnswer> ElectronicInspectionAnswers { get; set; } = new List<ElectronicInspectionAnswer>();

    public virtual ICollection<ElectronicInspectionReportAnswerLog> ElectronicInspectionReportAnswerLogs { get; set; } = new List<ElectronicInspectionReportAnswerLog>();

    public virtual ICollection<ElectronicInspectionReportAnswer> ElectronicInspectionReportAnswers { get; set; } = new List<ElectronicInspectionReportAnswer>();
}
