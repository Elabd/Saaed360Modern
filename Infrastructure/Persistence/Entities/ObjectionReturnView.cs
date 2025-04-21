using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ObjectionReturnView
{
    public long RequestId { get; set; }

    public DateTime RequestDate { get; set; }

    public string MobileNumber { get; set; } = null!;

    public string? Client { get; set; }

    public int RequestStatusId { get; set; }

    public string RequestStatus { get; set; } = null!;

    public int RequestTypeId { get; set; }

    public string RequestType { get; set; } = null!;

    public string EnglishRequestType { get; set; } = null!;

    public string RequestBody { get; set; } = null!;

    public string? ReturnReason { get; set; }

    public int? MobileUserId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime? ReportDateTime { get; set; }
}
