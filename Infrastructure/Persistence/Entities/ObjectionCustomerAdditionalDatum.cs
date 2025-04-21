using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ObjectionCustomerAdditionalDatum
{
    public long ObjectionCustomerAdditionalDataId { get; set; }

    public string? EmirateId { get; set; }

    public string? Tcn { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? ModifictionDateTime { get; set; }

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();

    public virtual ICollection<Objection> Objections { get; set; } = new List<Objection>();
}
