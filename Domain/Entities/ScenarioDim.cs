using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ScenarioDim
{
    public int ScenarioId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();
}
