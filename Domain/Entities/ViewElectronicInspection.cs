using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewElectronicInspection
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime ReportDate { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public Guid? TransporterId { get; set; }

    public string? TransporterName { get; set; }

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
}
