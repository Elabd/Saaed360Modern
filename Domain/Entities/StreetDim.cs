using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class StreetDim
{
    public long StreetId { get; set; }

    public string StreetName { get; set; } = null!;

    public string? StreetCode { get; set; }

    public long SectorId { get; set; }

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual SectorDim Sector { get; set; } = null!;

    public virtual ICollection<StreetCrossStreet> StreetCrossStreets { get; set; } = new List<StreetCrossStreet>();
}
