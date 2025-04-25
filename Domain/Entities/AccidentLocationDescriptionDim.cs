using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AccidentLocationDescriptionDim
{
    public long AccidentLocationDescriptionId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();
}
