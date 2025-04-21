using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtGetRspImage
{
    public long ImageId { get; set; }

    public int ReportId { get; set; }

    public string? ImageName { get; set; }

    public byte[]? ImageByte { get; set; }
}
