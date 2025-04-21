using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReport
{
    public long Id { get; set; }

    public DateOnly? Day { get; set; }

    public TimeOnly? FromPeriod { get; set; }

    public TimeOnly? ToPeriod { get; set; }

    public long CreationUserId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public long ElectronicInspectionReportStatusId { get; set; }

    public bool? IsViewed { get; set; }

    public string? ReplacedComputer { get; set; }

    public string? ReplacedPrinter { get; set; }

    public string? ReplacedCommunicationMachine { get; set; }

    public string? Code { get; set; }

    public DateTime? FullDateFrom { get; set; }

    public DateTime? FullDateTo { get; set; }

    public string? Comment { get; set; }

    public Guid? ParentBranchId { get; set; }

    public string? ParentBranchName { get; set; }

    public Guid? SubBaranchId { get; set; }

    public string? SubBranchName { get; set; }

    public Guid? TransporterId { get; set; }

    public string? TransporterName { get; set; }

    public string? TransporterNumber { get; set; }

    public string? TransporterColor { get; set; }

    public string? TransporterType { get; set; }

    public string? TransporterCode { get; set; }

    public string? TransporterMileage { get; set; }

    public long? FmsreportStatusId { get; set; }

    public string? GeneralNotes { get; set; }

    public virtual ICollection<ElectronicInspectionPatrolAttendance> ElectronicInspectionPatrolAttendances { get; set; } = new List<ElectronicInspectionPatrolAttendance>();

    public virtual ICollection<ElectronicInspectionReportAnswerLog> ElectronicInspectionReportAnswerLogs { get; set; } = new List<ElectronicInspectionReportAnswerLog>();

    public virtual ICollection<ElectronicInspectionReportAnswer> ElectronicInspectionReportAnswers { get; set; } = new List<ElectronicInspectionReportAnswer>();

    public virtual ICollection<ElectronicInspectionReportDamagePart> ElectronicInspectionReportDamageParts { get; set; } = new List<ElectronicInspectionReportDamagePart>();

    public virtual ICollection<ElectronicInspectionReportDamagePartslog> ElectronicInspectionReportDamagePartslogs { get; set; } = new List<ElectronicInspectionReportDamagePartslog>();

    public virtual ICollection<ElectronicInspectionReportDocument> ElectronicInspectionReportDocuments { get; set; } = new List<ElectronicInspectionReportDocument>();

    public virtual ICollection<ElectronicInspectionReportLog> ElectronicInspectionReportLogs { get; set; } = new List<ElectronicInspectionReportLog>();

    public virtual ElectronicInspectionReportStatus ElectronicInspectionReportStatus { get; set; } = null!;
}
