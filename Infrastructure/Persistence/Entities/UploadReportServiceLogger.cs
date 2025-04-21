using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UploadReportServiceLogger
{
    public long LogId { get; set; }

    public string? RequestXml { get; set; }

    public string? ResponseXml { get; set; }

    public string? Adpnumber { get; set; }

    public DateTime? RequestedTimeStamp { get; set; }
}

