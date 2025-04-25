using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ElectronicInspectionAnswer
{
    public long Id { get; set; }

    public string ArName { get; set; } = null!;

    public string EnName { get; set; } = null!;

    public bool IsDefault { get; set; }

    public bool IsDamage { get; set; }

    public long? ElectronicInspectionQuestionId { get; set; }

    public Guid? Fmscode { get; set; }

    public virtual ElectronicInspectionQuestion? ElectronicInspectionQuestion { get; set; }

    public virtual ICollection<ElectronicInspectionReportAnswerLog> ElectronicInspectionReportAnswerLogs { get; set; } = new List<ElectronicInspectionReportAnswerLog>();

    public virtual ICollection<ElectronicInspectionReportAnswer> ElectronicInspectionReportAnswers { get; set; } = new List<ElectronicInspectionReportAnswer>();
}
