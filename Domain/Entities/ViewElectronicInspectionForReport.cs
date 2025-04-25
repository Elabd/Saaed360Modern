using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewElectronicInspectionForReport
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime ReportDate { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public Guid? TransporterId { get; set; }

    public string? TransporterName { get; set; }

    public string? TransporterCode { get; set; }

    public string? PlateColor { get; set; }

    public string? TransporterType { get; set; }

    public string? ReplacedComputer { get; set; }

    public string? ReplacedPrinter { get; set; }

    public string? ReplacedCommunicationMachine { get; set; }

    public string? Comment { get; set; }

    public long StatusId { get; set; }

    public bool? IsViewed { get; set; }

    public Guid? SubBranchId { get; set; }

    public string? SubBranchName { get; set; }

    public Guid? ParentBranchId { get; set; }

    public string? ParentBranchName { get; set; }

    public long UserId { get; set; }

    public string? Status { get; set; }

    public string? UserName { get; set; }

    public string? SystemUserName { get; set; }

    public string? TransporterMileage { get; set; }

    public DateTime? LogoutDate { get; set; }

    public long? PatrolAttendanceId { get; set; }

    public string? GeneralNotes { get; set; }
}
