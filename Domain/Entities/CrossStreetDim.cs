using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CrossStreetDim
{
    public long CrossStreetId { get; set; }

    public string Name { get; set; } = null!;

    public string? Code { get; set; }

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual ICollection<StreetCrossStreet> StreetCrossStreets { get; set; } = new List<StreetCrossStreet>();
}
