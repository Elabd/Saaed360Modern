using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtGetRspProcedure
{
    public int ReportId { get; set; }

    public long RspProceduresId { get; set; }

    public string? ProceduresList { get; set; }

    public string? Comments { get; set; }
}
