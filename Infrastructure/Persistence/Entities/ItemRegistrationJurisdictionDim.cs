using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemRegistrationJurisdictionDim
{
    public int ItemRegistrationJurisdictionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ItemRegistration> ItemRegistrations { get; set; } = new List<ItemRegistration>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
