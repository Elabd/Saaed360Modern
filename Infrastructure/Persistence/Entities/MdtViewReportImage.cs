using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtViewReportImage
{
    public long ImageId { get; set; }

    public string? BinaryLocationUri { get; set; }

    public int ReportId { get; set; }

    public string? ImageName { get; set; }

    public byte[]? BinaryBase64Object { get; set; }
}
