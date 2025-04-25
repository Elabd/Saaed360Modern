using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistrationAuthorityDim
{
    public int ItemRegistrationAuthorityId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ItemRegistration> ItemRegistrations { get; set; } = new List<ItemRegistration>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
