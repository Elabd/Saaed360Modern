using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MdtGetRspImage
{
    public long ImageId { get; set; }

    public int ReportId { get; set; }

    public string? ImageName { get; set; }

    public byte[]? ImageByte { get; set; }
}
