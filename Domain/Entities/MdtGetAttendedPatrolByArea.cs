using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MdtGetAttendedPatrolByArea
{
    public long PatrolId { get; set; }

    public long? RelatedAreaId { get; set; }

    public DateTime? LoginDate { get; set; }
}
