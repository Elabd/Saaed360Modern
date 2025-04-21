using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RspProcedure
{
    public long RspProceduresId { get; set; }

    public string? ProceduresList { get; set; }

    public int? ReportId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public string? Comments { get; set; }

    public virtual Report? Report { get; set; }
}
