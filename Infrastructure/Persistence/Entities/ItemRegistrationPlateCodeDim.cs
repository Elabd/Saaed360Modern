using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemRegistrationPlateCodeDim
{
    public int ItemRegistrationPlateCodeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ItemRegistration> ItemRegistrations { get; set; } = new List<ItemRegistration>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

