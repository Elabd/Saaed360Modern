using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Provider
{
    public long OrganizationId { get; set; }

    public int ProviderCategoryId { get; set; }

    public int ProviderStatusId { get; set; }

    public DateOnly? ContractStartDate { get; set; }

    public DateOnly? ContractEndDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual ProviderCategoryDim ProviderCategory { get; set; } = null!;

    public virtual ProviderStatusDim ProviderStatus { get; set; } = null!;
}
