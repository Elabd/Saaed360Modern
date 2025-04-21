using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportAnswerLog
{
    public long Id { get; set; }

    public long ElectronicInspectionReportId { get; set; }

    public long ActionUserId { get; set; }

    public string ActionUserName { get; set; } = null!;

    public DateTime ActionDateTime { get; set; }

    public long? ElectronicInspectionAnswerId { get; set; }

    public string? ElectronicInspectionAnswerName { get; set; }

    public long? ElectronicInspectionQuestionId { get; set; }

    public string? ElectronicInspectionQuestionName { get; set; }

    public long ElectronicInspectionReportAnswerStatusId { get; set; }

    public string? ElectronicInspectionReportAnswerStatus { get; set; }

    public bool? IsDamage { get; set; }

    public string? Comment { get; set; }

    public string? SentGroup { get; set; }

    public string? MaintenanceComment { get; set; }

    public string? UserName { get; set; }

    public virtual ElectronicInspectionAnswer? ElectronicInspectionAnswer { get; set; }

    public virtual ElectronicInspectionQuestion? ElectronicInspectionQuestion { get; set; }

    public virtual ElectronicInspectionReport ElectronicInspectionReport { get; set; } = null!;
}
